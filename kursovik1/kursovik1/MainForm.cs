using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace kursovik1
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		List<Disk> disklist = new List<Disk>(); //Список класса Disk. Используется для того, чтобы обращаться к диску в любых методах
		List<File> filelist = new List<File>();//Список файлов
		
		List<Cluster> clusterlist = new List<Cluster>();//список кластеров
		List<Cluster> sortedclusterlist = new List<Cluster>();//сортированный список кластеров
		List<Cluster> dataclusterlist = new List<Cluster>();//список кластеров под данные
		
		List<int> freeclusters = new List<int>();//список с номерами свободных кластеров
		int clustersamount;//количество кластеров
		int freeclustersamount;//количество свободных кластеров
		int filespace;//место, занятое файлами
		Random shakerandom = new Random();
		
		void Button2Click(object sender, EventArgs e)
		{
			groupBox2.Visible = true;
		}
		//Процедуры создания диска, файла, распределения файла по кластерам.
		void Button_createdisk_Click(object sender, EventArgs e)
		{
			if(!CheckErrors(disksizebox.Text)){ //Если нет ошибок
			Disk newdisk = new Disk(int.Parse(disksizebox.Text),int.Parse(clustersizebox.Text));// в newdisk записываем значения полей
			newdisk.FreeSpace = (newdisk.Size*1024)-2*newdisk.ClusterSize; //так как два кластера уходят под систему, места на диске становится меньше. Объем диска становится равным Размер диска - 2*размер одного кластера
			groupBox1.Enabled=false;//Убираем возможность создавать новые диски
			disklist.Add(newdisk);//Добавляем в список дисков новый диск для удобства работы с ним 
			
			clustersamount = disklist[0].Size*1024/disklist[0].ClusterSize;//Количество кластеров - размер диска*1024 ( переводим в кб) / размер кластера
			
			freeclustersamount=(disklist[0].Size*1024/disklist[0].ClusterSize)-2; //Количество свободных кластеров = размер диска*1024/ размер кластера
			// Графическое оформление

			label_disksize.Text=(disklist[0].Size*1024).ToString(); 
			label_freespace.Text=disklist[0].FreeSpace.ToString();
			label_systemclusterspace.Text=(disklist[0].ClusterSize*2).ToString();
			label_filled_.Text=(disklist[0].Size*1024-disklist[0].FreeSpace).ToString();
			//Графическое оформление

			CreateClusterMap();//Создаем карту кластеров
			CreatetheGrid();//Создам компонент datagridview
			FilltheGrid();// Заполняем компонент datagridview 
			groupBox2.Enabled=true;//Добавляем возможность добавлять файлы
			}
			else{//Если есть ошибки
				ShowErrorMessage();//Выводим сообщение об ошибке
			}
			
		}
		void DecomposeIntoClusters(File file){//Процедура распределяет файл по кластерам. 
			
			Random r = new Random();//Переменная типа random для фрагментированного распределения файлов
			
			
			int filesize = file.Size;
			while(filesize>0){//Пока размер файла > 0 
				Cluster cluster= new Cluster();//Создам переменную класса Cluster
				cluster.LinkedFileNumber=file.Number;// Номер кластера, в котором лежит файл/его часть = номер файла
				cluster.ClusterColor=file.FileColor;//Цвет кластера, в котором лежит файл/его часть = цвет файла.
				if(filesize-disklist[0].ClusterSize>0){//Если размер файла-размер кластера>0
					cluster.Volume=disklist[0].ClusterSize;//объем переменной cluster равен размеру кластера диска
				}
				
				else{//иначе
					cluster.Volume=filesize;//объем занятого файлом места равен размеру файла
					
				}
				FillFreeClusterlist();//Заполняем список свободных для вставки кластеров
				ShakeList(freeclusters);//перемешиваем список свободных кластеров, полученных в прошлой процедуре
				if(freeclusters.Count>0)//если свободных кластеров больше 0 
				{
				int clusternumber = freeclusters[0];//Номер кластера, в котором будет размещен файл - нулевой элемент списка freeclusters
				dataclusterlist[clusternumber].Volume+=cluster.Volume;//объем кластера с номером clusternumber равен объему, полученному в цикле выше
				dataclusterlist[clusternumber].ClusterColor=cluster.ClusterColor;//цвет кластера равен цвету переменной cluster ( цвету файла, к которому эта переменная привязана)
				dataclusterlist[clusternumber].LinkedFileNumber=cluster.LinkedFileNumber;//Данный кластер получает номер привязанного к нему файла.
				freeclusters.RemoveAt(0);//из списка свободных кластеров удаляется номер свободных кластеров
				filesize-=disklist[0].ClusterSize;//размер файла уменьшается на размер кластера диска
				}
				
				
			}
		}
		void Button_defragmentthedisk_Click(object sender, EventArgs e)//дефрагментация диска
		{
			
				SortClusterList();//сортируется список кластеров
				ShowDefragmentClusterMap();//графическое отображение карты кластеров			
		}
		void Button_cleandisk_Click(object sender, EventArgs e)//Очищение всех компонентов приложения
		{
			for(int i=0;i<clustersamount/8;i++){
				for(int j=0;j<clustersamount/(clustersamount/8);j++){
					
					
					
						dataGridView1.Rows[i].Cells[j].Value="";
						dataGridView1.Rows[i].Cells[j].Style.BackColor=Color.White;
					
					
				}
			}
			//Перевод datagridview в первоначальное состояние
			disklist.Clear();
			clusterlist.Clear();
			dataclusterlist.Clear();
			sortedclusterlist.Clear();
			freeclusters.Clear();
			filelist.Clear();
			label_disksize.Text="";
			label_filespace.Text="";
			label_freespace.Text="";
			label_systemclusterspace.Text="";
			label_filled_.Text="";
			groupBox1.Enabled=true;
			groupBox2.Enabled=false;
			groupBox4.Enabled=false;
			clustersamount=0;
			freeclustersamount=0;
			filespace=0;
		}
		void CreateClusterMap(){ // Метод создает карту кластеров, доступных для заполнения файлами
			for(int i=0;i<freeclustersamount;i++){
				Cluster emptycluster = new Cluster();
				emptycluster.Volume=0; 
				emptycluster.LinkedFileNumber=-1;
				dataclusterlist.Add(emptycluster); //В список dataclusterlist добавляется пустой кластер
			}
		}
		void Button_createfile_Click(object sender, EventArgs e) //Создание файла
		{	
			if(!CheckErrors(filesizebox.Text))//Если ошибок нет
			{
			File newfile = new File(int.Parse(filesizebox.Text),filelist.Count); //в переменную класса File записываем размер файла и его номер на диске
			newfile.SizeOnDisk=ConvertToSizeOnDisk(newfile);//конвертируем файл в размер на диске
			if(disklist[0].FreeSpace-newfile.SizeOnDisk>=0 && newfile.SizeOnDisk<=disklist[0].ClusterSize*100) //если после добавления файла места на диске будет больше или равно 0 или размер файла меньше чем (размер кластера)*100
			{
				if(filelist.Count>1){ //цикл для задания разных номеров у файлов, чтобы при удалении удалялся один файл, а не несколько
					for(int i=0;i<filelist.Count;i++){
						if (newfile.Number==filelist[i].Number){
							newfile.Number+=1;
						}
					}
				}
				Random colorrandomizer = new Random(); //переменная класса random для определения случайного цвета
				filelist.Add(newfile); //в список файла добавляем файл
				filespace+=newfile.SizeOnDisk;//К значению поля filespace прибавляем размер файла на диске
				disklist[0].FreeSpace-=newfile.SizeOnDisk;//от свободного места диска отнимаем размер файла на диске
				
				newfile.FileColor=Color.FromArgb(colorrandomizer.Next(0,255),colorrandomizer.Next(0,255),colorrandomizer.Next(0,255));//цвет файла при переводе в RGB равен трем случайным числам, каждое из которых отвечает за каждый цвет
				DecomposeIntoClusters(newfile);//распределяем файл по кластерам
				ShowtheClusterMap();//после добавления файла и распределния по кластерам показываем карту кластеров
				//Изменяются графические компоненты, показывающие пользователю размер свободного на диске места, объем оставшийся на диске и объем, который занимают файлы на диске
				label_freespace.Text=disklist[0].FreeSpace.ToString();
				label_filled_.Text=(disklist[0].Size*1024-disklist[0].FreeSpace).ToString();
				label_filespace.Text=filespace.ToString();
				groupBox4.Enabled=true;//Позволяет удалить файл
				
			}
			else if(disklist[0].FreeSpace-newfile.SizeOnDisk<0) //если места недостаточно то выводим сообщение об ошибке
			{
				MessageBox.Show("Недостаточно места на диске для добавления файла или файл превышает допустимые размеры (смотреть справку)");
			}
			}
			else{
				ShowErrorMessage();//если неправильно введены данные, выводим сообщение об ошибке
			}
			
			
			
			
		}
		int ConvertToSizeOnDisk(File file){//Конвертируем размер файла в размер на диске в зависимости от размер кластера
			int minsize=0; //переменная, отвечающая за минимальный размер файла на диске
			int filesize = file.Size; //размер файла
			while(filesize>0){//пока размер файла >0
				filesize-=disklist[0].ClusterSize;//от размера файла отнимаем размер кластера
				minsize+=disklist[0].ClusterSize;//к минимальному размеру прибавляем размер кластера
			}
			return minsize;
		}
		
		
//		Графическое оформление
		void CreatetheGrid(){
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.ColumnHeadersVisible=false;
			dataGridView1.ColumnCount=8;// Для удобства количество колонок равно 8
			dataGridView1.RowCount=(clustersamount/8);//количество строк равно количество кластеров/8. Количество кластеров на диске в данной программе всегда кратно 8. Сделано для удобства и избавления от пустых клеток datagridview
			for(int i=0;i<8;i++){
				dataGridView1.Columns[i].Width=40; //устанавливаем ширину столбцов
			}
			
		}
		void FilltheGrid(){//заполняем компонент датагрид. Вызывается только 1 раз при создании диска для показа пустых кластеров
			for(int i=0;i<clustersamount/8;i++){ // 8 столбцов
				for(int j=0;j<clustersamount/(clustersamount/8);j++){ //находим количество строк делением количеством кластеров на количество столбцов
					
					if(i==0 && j<2){
						dataGridView1.Rows[i].Cells[j].Value="СК"; //первые 2 ячейки заполняем системными кластерами СК
					}
					else if (i>0 || j>=2)
					{
						dataGridView1.Rows[i].Cells[j].Value=dataclusterlist[i*8+j-2].Volume; //остальные кластеры заполняем объемом кластеров
						
					}
					
				}
			}
		}
		void ShowtheClusterMap(){//Вывод карты кластеров. Вызывается каждый раз при добавлении файла на диск
			for(int i=0;i<clustersamount/8;i++){
				for(int j=0;j<clustersamount/(clustersamount/8);j++){
					
					if(i==0 && j<2){
						dataGridView1.Rows[i].Cells[j].Value="СК";//перрвые 2 ячейки заполняем системными кластерами СК
					}
					else if (i>0 || j>=2)
					{
						dataGridView1.Rows[i].Cells[j].Value=dataclusterlist[i*8+j-2].Volume;//остальные заполняем объемом кластеров. i*8 - заполнение идет при переносе на новую строку. j-2 тк первые 2 кластера - системные
						dataGridView1.Rows[i].Cells[j].Style.BackColor=dataclusterlist[i*8+j-2].ClusterColor;//цвет ячейки равен цвету кластера
					}
					
				}
			}
		}
		void ShowDefragmentClusterMap(){ //Вывод дефрагментированного диска. В отличие от метода showtheclustermap, здесь идет работа с уже отсортированным списком кластеров по номеру файла на диске
			for(int i=0;i<clustersamount/8;i++){
				for(int j=0;j<clustersamount/(clustersamount/8);j++){
					
					if(i==0 && j<2){
						dataGridView1.Rows[i].Cells[j].Value="СК";
					}
					else if (i>0 || j>=2)
					{
						dataGridView1.Rows[i].Cells[j].Value=sortedclusterlist[i*8+j-2].Volume;
						dataGridView1.Rows[i].Cells[j].Style.BackColor=sortedclusterlist[i*8+j-2].ClusterColor;
					}
					
				}
			}
		}
		//Вспомогательные процедуры
		void FillFreeClusterlist(){ //Метод для поиска пустых кластеров
			freeclusters.Clear();//очищаем список freeclusters
			
			for(int i=0;i<dataclusterlist.Count;i++){
				if(dataclusterlist[i].Volume==0){ //Если кластер еще пустой
					freeclusters.Add(i);//Добавляем его номер в список freeclusters
					
				}
			}
			
			
			
		}
		void ShakeList(List<int> listtoshake)//Перемешивает список номеров пустых кластеров
		{
			
			for (int i = 0; i < listtoshake.Count; i++)
            {
                int tmp = listtoshake[0]; // в переменную tmp записываем нулевой элемент списка номеров пустых кластеров
                listtoshake.RemoveAt(0);//удаляем этот элемент и 
                listtoshake.Insert(shakerandom.Next(listtoshake.Count), tmp);//вставляем tmp в рандомное место списка
            }
		} 
		void SortClusterList( ){ //сортировка списка кластеров
			sortedclusterlist.Clear();//чистим сортированный список кластеров
			for(int i=0;i<dataclusterlist.Count;i++){
				for(int j=i+1;j<dataclusterlist.Count;j++){
					if(dataclusterlist[i].LinkedFileNumber<dataclusterlist[j].LinkedFileNumber){//сортируем список по возрастанию номеров файлов
						Cluster cluster = dataclusterlist[i];
						dataclusterlist[i] = dataclusterlist[j];
						dataclusterlist[j]=cluster;

					}
				}
			}
			for(int i=0;i<dataclusterlist.Count;i++){
				for(int j=i+1;j<dataclusterlist.Count;j++){
					if(dataclusterlist[i].LinkedFileNumber==dataclusterlist[j].LinkedFileNumber && dataclusterlist[i].Volume<dataclusterlist[j].Volume)
					{
						Cluster cluster = dataclusterlist[i];
						dataclusterlist[i] = dataclusterlist[j];
						dataclusterlist[j]=cluster;
					}
				}
			}
			sortedclusterlist.AddRange(dataclusterlist);//в список sortedclusterlist добавляем сортированный список dataclusterlist
		} 
		bool CheckErrors(string text){//ищет ошибки 
			bool error = false;
			for(int i=0;i<text.Length;i++){
				char c = text[i];
				if(!Char.IsNumber(c)){// если хотя бы один элемент текста не цифра - error = true
					error = true;
				}
			}
			if(text.Length==0){
				error=true;
			}
			return error;
		} //Ищет ошибки
		void ShowErrorMessage(){
			MessageBox.Show("Ошибка. Смотреть правила ввода в пункте <<Справка>>");
		}
		void Button_deletefileClick(object sender, EventArgs e)
		{
			if (!CheckErrors(textBox1.Text))
			{int filenumber = int.Parse(textBox1.Text);//Номер файла берем из текстового поля
			
			for(int i=0;i<dataclusterlist.Count;i++){
				if (dataclusterlist[i].LinkedFileNumber==filenumber){//если номер кластера, к которому привязан файл, равен введенному
					dataclusterlist[i].Volume=0;//Объем кластера = 0
					dataclusterlist[i].LinkedFileNumber=-1;//номер становится равным -1 ( ни к какому не привязан)
					dataclusterlist[i].ClusterColor=Color.White;//цвет кластера белый (графический. показывает на datagridview пустой кластер)
				}
			}
			for(int i=0;i<filelist.Count;i++){
				int number = filelist[i].Number;//number - номер i-того элемента списка filelist
				if (number==filenumber){//если number равен введенному
					label_filespace.Text=(int.Parse(label_filespace.Text)-filelist[i].SizeOnDisk).ToString();//уменьшается значение объема, занятого файлами
					filespace-=filelist[i].SizeOnDisk;//от поля filespace отнимается дисковой размер файла, которого удаляем
					label_filled_.Text=(int.Parse(label_filled_.Text)-filelist[i].SizeOnDisk).ToString();//уменьшается значение занятого места
					label_freespace.Text=(int.Parse(label_freespace.Text)+filelist[i].SizeOnDisk).ToString();//увеличивается значение свободного места
					disklist[0].FreeSpace+=filelist[i].SizeOnDisk;//к свободному месту на диске прибавляем дисковой размер файла
					filelist.RemoveAt(i);//удаляем из списка файлов данный файл
					
				}
			}
			ShowtheClusterMap();//показываем карту кластеров после удаления файла
			}
			else{
				ShowErrorMessage();
			}
		}
		void Button_help_Click(object sender, EventArgs e)//Вывод справки
		{
			MessageBox.Show("Программа-имитатор дискового распределения памяти демонстрирует логическую модель жесткого диска");
			MessageBox.Show("Для создания диска введите размер диска в МБ (целое неотрицательное число) и выберите размер кластера среди предложенных (2,4,8,16,32 КБ). Затем нажмите кнопку <<Создать диск>>. Программа преобразует данное значение в килобайты ( смотреть блок <<О диске>> ).");
			MessageBox.Show("В окне слева появится таблица кластеров, где первые 2 кластера заняты системными данными, остальные выделены под файлы.");
			MessageBox.Show("Для создания файла и добавления его на диск необходимо в соответствующем блоке ввести размер файла (целое неотрицательное число, не превышающее размер кластера диска*100).  Он разделится на кластеры и выделится на карте кластеров соответсвующим цветом.");
			MessageBox.Show("Для дефрагментации диска нажмите на кнопку <<Дефрагментировать диск>> ");
			MessageBox.Show("Для удаления файла введите его номер в текстовое поле в блоке <<Удаление>>. Нумерация начинается с нуля.");
			MessageBox.Show("Разработал Демин Марк, БПИ-211");
		}

	}
	public class Disk{
			private int size;//размер диска
			private int clustersize;//размер кластера
			private int freespace;//свободное место
			public int Size{
				get{return size;}
				set{this.size = value;}
			}
			public int ClusterSize{
				get{return clustersize;}
				set{this.clustersize=value;}
			}
			public int FreeSpace{
				get{return freespace;}
				set{this.freespace = value;}
			}
			public Disk(int size,int clustersize){
				this.size=size;
				this.clustersize=clustersize;
			}
		}
	public class File{
			int size;//размер диска
			int sizeondisk;//размер на диске
			int number;//номер файла 
			Color filecolor;//цвет файла ( графическое )
			public int Size{
				get{return size;}
				set{this.size=value;}
			}
			public int SizeOnDisk{
				get{return sizeondisk;}
				set{this.sizeondisk=value;}
			}
			public int Number{
				get{return number;}
				set{this.number=value;}
			}
			public Color FileColor{
				get{return filecolor;}
				set{this.filecolor=value;}
			}
			public File(int size, int number){
				this.size = size;
				this.number = number;
			}
		}
	public class Cluster{
		int linkedfilenumber;//номер файла, к которому будет привязываться кластер
		int volume;//объем кластера
		
		string name;//имя кластера
		Color clustercolor;//цвет кластера. определяется файлом, к которому кластер привязан (графическое)
		public int LinkedFileNumber{
			get{return linkedfilenumber;}
			set{this.linkedfilenumber = value;}
		}
		
		public int Volume{
			get{return volume;}
			set{this.volume=value;}
		}
		public string Name{
			get{return name;}
			set{this.name=value;}
		}
		
		public Color ClusterColor{
			get{return clustercolor;}
			set{this.clustercolor=value;}
		}
	}
}

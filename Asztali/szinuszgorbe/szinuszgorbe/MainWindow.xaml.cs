


namespace szinuszgorbe
{
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;
    using System.Windows.Threading;



    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    //1.kordinata rendszer
    //2.kör(vekony)
    //3.fekete pont
    //4.sugar
    //5.magassag(piros)
    //6.szinusz görbe
    //7.korív(nagy)
    //8.körív(kicsi)
    //9.adattábla(szög egyebek)
    //sine curve and the unit circle
    public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
            }
            int x = 0;
            bool novekszik = true;
            void rajzol(object sender, EventArgs e) 
            {
            origoX = r * 1.1;
            origoY = Height / 2;
            vaszon.Children.Clear();

            

            kordinataRajzol();

            kor(x);
            sugar(x);
            pirosVonal(x);
            pont(x);
            korivNagy(x);
            korivKicsi(x);
            hullam(x);
            if (novekszik)
            {
                x += 1;
            }
            else 
            {
                x -= 1;
            }
            if (x >= 360 || x <= 0) 
            {
                
                novekszik=!novekszik;
            }
            
            

        }
        private void vaszon_Loaded(object sender, RoutedEventArgs e)
            {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += rajzol;
            timer.Interval = TimeSpan.FromMilliseconds(10);
            timer.Start();
            }
            int r = 100;
            double origoY = 0;
            double origoX = 0;
            void kordinataRajzol()
            {
                Line xTengely = new Line();
                xTengely.Stroke = Brushes.Black;
                xTengely.X1 = 0;
                xTengely.Y1 = Height / 2;
                xTengely.X2 = Width;
                xTengely.Y2 = Height / 2;



                Line yTengely = new Line();
                yTengely.Stroke = Brushes.Black;
                yTengely.X1 = r * 1.1;
                yTengely.Y1 = 0;
                yTengely.X2 = r * 1.1;
                yTengely.Y2 = Height;


                vaszon.Children.Add(xTengely);
                vaszon.Children.Add(yTengely);

                for (int i = 0; i < 5; i++)
                {
                    Line vonalka = new Line();
                    vonalka.Stroke = Brushes.Black;
                    vonalka.X1 = i * 90 + yTengely.X1;
                    vonalka.Y1 = Height / 2 - 5;
                    vonalka.X2 = i * 90 + yTengely.X1;
                    vonalka.Y2 = Height / 2 + 5;
                    vaszon.Children.Add(vonalka);
                }

                for (int i = 0; i < 5; i++)
                {
                    Line vonalka = new Line();
                    vonalka.Stroke = Brushes.Black;
                    vonalka.X1 = yTengely.X1 - 5;
                    vonalka.Y1 = i * 90 + (xTengely.Y1 - 180);
                    vonalka.X2 = yTengely.X1 + 5;
                    vonalka.Y2 = i * 90 + (xTengely.Y1 - 180);
                    vaszon.Children.Add(vonalka);
                }
            }
            int korX = 0;
            int korY = 0;
            void kor(int x)
            {
            int dX = (int)(Math.Cos(x / 180.0 * Math.PI) * r);

                Ellipse kor = new Ellipse();
                kor.Stroke = Brushes.Blue;
                kor.Height = 2 * r;
                kor.Width = 2 * r;
                kor.Margin = new Thickness(x+origoX -dX-r, origoY-r, 0, 0);

                korX = Convert.ToInt32(x - r + origoX);
                korY = Convert.ToInt32(origoY);
                vaszon.Children.Add(kor);
            }

            void sugar(int x)
            {
            int magassag = (int)(Math.Sin(x / 180.0 * Math.PI) * r);
            int dX = (int)(Math.Cos(x / 180.0 * Math.PI) * r);

            Line vonal = new Line();
            vonal.Stroke = Brushes.Gray;
         
            vonal.StrokeThickness = 1;
            vonal.X1 = x + origoX-dX;
            vonal.Y1 = origoY;
            vonal.X2 = x + origoX;
            vonal.Y2 = origoY - magassag;

            vaszon.Children.Add(vonal);
        }

            void pont(int x)
            {
                Ellipse pont = new Ellipse();
                pont.Stroke = Brushes.Black;
                pont.Height = r * .1;
                pont.Width = r * .1;
                pont.Margin = new Thickness(origoX - pont.Width / 2 + x, origoY - pont.Height / 2, 0, 0);
                pont.Fill = Brushes.Black;

                vaszon.Children.Add(pont);
            }

            void pirosVonal(int x)
            {
                int magassag = (int)(Math.Sin(x / 180.0 * Math.PI) * r);

                Line vonal = new Line();
                vonal.Stroke = Brushes.Red;
                vonal.StrokeThickness = 3;
                vonal.X1 = x + origoX;
                vonal.Y1 = origoY;
                vonal.X2 = x + origoX;
                vonal.Y2 = origoY - magassag;

                vaszon.Children.Add(vonal);
            }
            void korivNagy(int x) 
            {
            double dX = (Math.Cos(x / 180.0 * Math.PI) * r);
            double magassag = (Math.Sin(x / 180.0 * Math.PI) * r);

            double x1 = origoX + x - dX + r;
            double y1 = origoY;
            double x2 = x + origoX;
            double y2 = origoY - magassag;

            //double vonal.X2 = x + origoX;
            //double vonal.Y2 = origoY - magassag;



            Path path = new Path();
            path.Stroke = Brushes.Blue;
            path.StrokeThickness = 5;

            PathGeometry geometri = new PathGeometry();
            PathFigure figure = new PathFigure();
            figure.StartPoint = new Point(x1, y1);

            ArcSegment arc = new ArcSegment();
            arc.Point = new Point(x2, y2);

            arc.Size = new Size(r, r);
            arc.IsLargeArc = x>180;
            arc.SweepDirection = SweepDirection.Counterclockwise;

            figure.Segments.Add(arc);
            geometri.Figures.Add(figure);
            path.Data = geometri;

            vaszon.Children.Add(path);
            }
        void korivKicsi(int x)
        {
            double dX = (Math.Cos(x / 180.0 * Math.PI) * r);
            double magassag = (Math.Sin(x / 180.0 * Math.PI) * r);

            double x1 = origoX + x - dX + r/10;
            double y1 = origoY;
            double x2 = x + origoX - dX - (x + origoX - dX - (x + origoX)) * .1;
            double y2 = origoY-(origoY-(origoY-magassag))*.1;

            //double vonal.X2 = x + origoX;
            //double vonal.Y2 = origoY - magassag;



            Path path = new Path();
            path.Stroke = Brushes.Blue;
            path.StrokeThickness = 5;

            PathGeometry geometri = new PathGeometry();
            PathFigure figure = new PathFigure();
            figure.StartPoint = new Point(x1, y1);

            ArcSegment arc = new ArcSegment();
            arc.Point = new Point(x2, y2);

            arc.Size = new Size(r, r);
            arc.IsLargeArc = x > 180;
            arc.SweepDirection = SweepDirection.Counterclockwise;

            figure.Segments.Add(arc);
            geometri.Figures.Add(figure);
            path.Data = geometri;

            vaszon.Children.Add(path);
            
        }

        PointCollection pontok = new PointCollection();
        void hullam(int x) 
        {
            Polyline vonal = new Polyline();
            vonal.Stroke = Brushes.Red;
            vonal.StrokeThickness = 3;
            double magassag = Math.Sin(x/180.0 * Math.PI) * r;

            if (novekszik) 
            {
                pontok.Add(new Point(x+origoX, origoY- magassag));
            }
            else 
            {
                pontok.RemoveAt(x);
            }

            pontok.Add(new Point(x, magassag));
            vonal.Points = pontok;

            vaszon.Children.Add(vonal);
        }
    }
    }

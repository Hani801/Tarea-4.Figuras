//Haniar Gaudalupe Soto Arellano

namespace Introduccion;

public partial class Form1 : Form
{
    private Label? lblFigura;
    private ComboBox? cmbFiguras;
    private Label? lblCalculo;
    private ComboBox? cmbCalculos;
    private Label? lblAltura;
    private TextBox? txtAltura;
    private Label? lblResultado;
    private TextBox? txtResultado;
    private Button? btnCalcular;
    private Label? lblBase;
    private TextBox? txtBase;
    private Label? lblAlturaRec;
    private TextBox? txtAlturaRec;

    private Label? lblLadoA;
    private Label? lblLadoB;
    private Label? lblLadoC;

    private Label? lblAlturaTri;
    private TextBox? txtLadoA;

    private TextBox? txtLadoB;
    private TextBox? txtLadoC;
    private TextBox? txtAlturaTri;

       public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
        
    }

  
    private void InicializarComponentes()
    {
        // Tamaño de la ventana
        this.Size = new Size(300,350);

        //Etiqueta Figura
        lblFigura= new Label();
        lblFigura.Text="Figura";
        lblFigura.AutoSize=true;
        lblFigura.Location= new Point(10,10);

        //ComboBox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Selecciona figura");
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Rectángulo");
        cmbFiguras.Items.Add("Triángulo");
        cmbFiguras.SelectedIndex=0;
        cmbFiguras.Location= new Point(10,40);
        cmbFiguras.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);
     

        //Etiqueta Calculo
        lblCalculo= new Label();
        lblCalculo.Text="Cálculo";
        lblCalculo.AutoSize=true;
        lblCalculo.Location= new Point(150,10);

        //ComboBox Calculos
        cmbCalculos = new ComboBox();
        cmbCalculos.Items.Add("Selecciona calculo");
        cmbCalculos.Items.Add("Périmetro");
        cmbCalculos.Items.Add("Área");
        cmbCalculos.SelectedIndex=0;
        cmbCalculos.Location= new Point(150,40);
        cmbCalculos.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);

        //Etiqueta Altura
        lblAltura= new Label();
        lblAltura.Text="Altura";
        lblAltura.AutoSize=true;
        lblAltura.Location= new Point(10,80);
        lblAltura.Visible=false;

        //TextBox Altura
        txtAltura=new TextBox();
        txtAltura.Size = new Size(100,20);
        txtAltura.Location= new Point(60,75);
        txtAltura.Visible=false;

        //Etiqueta Altura
        lblResultado= new Label();
        lblResultado.Text="Resultado";
        lblResultado.AutoSize=true;
        lblResultado.Location= new Point(10,280);

        //TextBox Prueba
        txtResultado=new TextBox();
        txtResultado.Size = new Size(100,20);
        txtResultado.Location= new Point(70,275);

        //Boton Calcular
        btnCalcular= new Button();
        btnCalcular.Text="Calcular";
        btnCalcular.AutoSize=true;
        btnCalcular.Location= new Point(200,200);
        btnCalcular.Click+= new EventHandler(btnCalcular_Click);

             //Etiqueta Base
        lblBase= new Label();
        lblBase.Text="Base";
        lblBase.AutoSize=true;
        lblBase.Location= new Point(10,120);
        lblBase.Visible=false;

        //TextBox Base
        txtBase=new TextBox();
        txtBase.Size = new Size(100,20);
        txtBase.Location= new Point(60,120);
        txtBase.Visible=false;
        
           //Etiqueta Base
        lblAlturaRec= new Label();
        lblAlturaRec.Text="Altura";
        lblAlturaRec.AutoSize=true;
        lblAlturaRec.Location= new Point(10,80);
        lblAlturaRec.Visible=false;

        //TextBox Altura Réctangulo
        txtAlturaRec=new TextBox();
        txtAlturaRec.Size = new Size(100,20);
        txtAlturaRec.Location= new Point(60,75);
        txtAlturaRec.Visible=false;

              //Etiqueta Lado A
        lblLadoA= new Label();
        lblLadoA.Text="Lado A";
        lblLadoA.AutoSize=true;
        lblLadoA.Location= new Point(10,80);
        lblLadoA.Visible=false;

        //TextBox Lado A
        txtLadoA=new TextBox();
        txtLadoA.Size = new Size(100,20);
        txtLadoA.Location= new Point(60,75);
        txtLadoA.Visible=false;
        
           //Etiqueta Lado B
        lblLadoB= new Label();
        lblLadoB.Text="Lado B";
        lblLadoB.AutoSize=true;
        lblLadoB.Location= new Point(10,120);
        lblLadoB.Visible=false;

        //TextBox Lado B
        txtLadoB=new TextBox();
        txtLadoB.Size = new Size(100,20);
        txtLadoB.Location= new Point(60,120);
        txtLadoB.Visible=false;
//Etiqueta Lado C
        lblLadoC= new Label();
        lblLadoC.Text="Lado C";
        lblLadoC.AutoSize=true;
        lblLadoC.Location= new Point(10,160);
        lblLadoC.Visible=false;

        //TextBox Lado C
        txtLadoC=new TextBox();
        txtLadoC.Size = new Size(100,20);
        txtLadoC.Location= new Point(60,160);
        txtLadoC.Visible=false;

        //Etiqueta altura de Réctangulo
          
        lblAlturaTri= new Label();
        lblAlturaTri.Text="Altura";
        lblAlturaTri.AutoSize=true;
        lblAlturaTri.Location= new Point(10,80);
        lblAlturaTri.Visible=false;

        //TextBox Lado A
        txtAlturaTri=new TextBox();
        txtAlturaTri.Size = new Size(100,20);
        txtAlturaTri.Location= new Point(60,75);
        txtAlturaTri.Visible=false;
        
        

        //Agregar controles a la ventana
        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculos);
        this.Controls.Add(lblAltura);
        this.Controls.Add(txtAltura);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblBase);
        this.Controls.Add(txtBase);
        this.Controls.Add(lblAlturaRec);
        this.Controls.Add(txtAlturaRec);
        this.Controls.Add(lblLadoA);
        this.Controls.Add(lblLadoB);
        this.Controls.Add(lblLadoC);
        this.Controls.Add(txtLadoA);
        this.Controls.Add(txtLadoB);
        this.Controls.Add(txtLadoC);
        this.Controls.Add(lblAlturaTri);
        this.Controls.Add(txtAlturaTri);

     

      



    }
    private void cmb_ValueChanged(object sender, EventArgs e){

        if(cmbCalculos.SelectedIndex!=0 && cmbFiguras.SelectedIndex!=0){
            if(cmbFiguras.SelectedItem.ToString()=="Cuadrado"){
                //cmbFigura.SelectedIndex==1
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                }
            }
        if (cmbFiguras.SelectedItem.ToString()=="Rectángulo"){
            if (cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                txtAlturaRec.Visible=true;
                lblAlturaRec.Visible=true;
                txtBase.Visible=true;
                lblBase.Visible=true;
            }
           if (cmbCalculos.SelectedItem.ToString()=="Área"){
                txtAlturaRec.Visible=true;
                lblAlturaRec.Visible=true;
                txtBase.Visible=true;
                lblBase.Visible=true;
           }

        }
         if (cmbFiguras.SelectedItem.ToString()=="Triángulo"){ 
              if (cmbCalculos.SelectedItem.ToString()=="Périmetro"){
            txtLadoA.Visible=true;
            txtLadoB.Visible=true;
            txtLadoC.Visible=true;
            lblLadoA.Visible=true;
            lblLadoB.Visible=true;
            lblLadoC.Visible=true;
        }
        if (cmbCalculos.SelectedItem.ToString()=="Área"){
            txtAlturaTri.Visible=true;
            txtLadoB.Visible=true;
            lblAlturaTri.Visible=true;
            lblLadoB.Visible=true;
        }
       
        }
        }
        else
        {
            txtAltura.Visible=false;
            lblAltura.Visible=false;
            txtBase.Visible=false;
            lblBase.Visible=false;
            txtAlturaRec.Visible=false;
            lblAlturaRec.Visible=false;
            txtLadoA.Visible=false;
            txtLadoB.Visible=false;
            txtLadoC.Visible=false;
            lblLadoA.Visible=false;
            lblLadoB.Visible=false;
            lblLadoC.Visible=false;     
            txtAlturaTri.Visible=false;
            lblAlturaTri.Visible=false;
        }
     

    }
    
    private void btnCalcular_Click(object sender, EventArgs e){
     
        string calculo= cmbCalculos.SelectedItem.ToString();
        if(txtAltura.Text!=""){
            if(calculo=="Périmetro"){
                int altura= Convert.ToInt32(txtAltura.Text);
                txtResultado.Text=(altura*4).ToString();
            }
            if(calculo=="Área"){
                int altura= Convert.ToInt32(txtAltura.Text);
                txtResultado.Text=(altura*altura).ToString();
            }
        }
        if (txtAlturaRec.Text!="" && txtBase.Text!=""){
            if (calculo =="Périmetro"){
                int altura=Convert.ToInt32(txtAlturaRec.Text);
                int baseRect=Convert.ToInt32(txtBase.Text);
                //Falta 2 el dos
                txtResultado.Text=(2*(baseRect*altura)).ToString();
            }
             if (calculo =="Área"){
                int altura=Convert.ToInt32(txtAlturaRec.Text);
                int baseRect=Convert.ToInt32(txtBase.Text);
                txtResultado.Text=((baseRect*altura)).ToString();
            }
        
        }
        if (txtLadoA.Text!="" && txtLadoB.Text!="" && txtLadoC.Text!="" || txtAlturaTri.Text!="" ){
            if (calculo == "Périmetro"){
                int ladoA=Convert.ToInt32(txtLadoA.Text);
                int ladoB=Convert.ToInt32(txtLadoB.Text);
                int ladoC=Convert.ToInt32(txtLadoC.Text);
                txtResultado.Text=(ladoA+ladoB+ladoC).ToString();
            }
            if(calculo == "Área"){
              int altura=Convert.ToInt32(txtAlturaTri.Text);
              int ladoB=Convert.ToInt32(txtLadoB.Text);
              txtResultado.Text=((ladoB*altura)/2).ToString();
            }
        
       }
    }
      private void TextBoxnumeros_KeyPress(Object sender, KeyPressEventArgs e){
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar>=58 && e.KeyChar <=255)){
                MessageBox.Show("Solo números", "Alerta",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
}

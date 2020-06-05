namespace Demo
{
    partial class Demo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculatorLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.xValue = new System.Windows.Forms.TextBox();
            this.yValue = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divideButtton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultValue = new System.Windows.Forms.TextBox();
            this.productDataLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.productsDropdown = new System.Windows.Forms.ComboBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productNameValue = new System.Windows.Forms.TextBox();
            this.priceValue = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.quantityValue = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.addproductButton = new System.Windows.Forms.Button();
            this.clearProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculatorLabel
            // 
            this.calculatorLabel.AutoSize = true;
            this.calculatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatorLabel.Location = new System.Drawing.Point(170, 19);
            this.calculatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.calculatorLabel.Name = "calculatorLabel";
            this.calculatorLabel.Size = new System.Drawing.Size(144, 32);
            this.calculatorLabel.TabIndex = 0;
            this.calculatorLabel.Text = "Calculator";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(126, 107);
            this.xLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(20, 20);
            this.xLabel.TabIndex = 1;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yLabel.Location = new System.Drawing.Point(126, 165);
            this.yLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(19, 20);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "Y";
            // 
            // xValue
            // 
            this.xValue.Location = new System.Drawing.Point(176, 100);
            this.xValue.Name = "xValue";
            this.xValue.Size = new System.Drawing.Size(135, 30);
            this.xValue.TabIndex = 3;
            // 
            // yValue
            // 
            this.yValue.Location = new System.Drawing.Point(176, 158);
            this.yValue.Name = "yValue";
            this.yValue.Size = new System.Drawing.Size(135, 30);
            this.yValue.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(54, 251);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(108, 43);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(54, 300);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(108, 43);
            this.subtractButton.TabIndex = 6;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(54, 349);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(108, 43);
            this.multiplyButton.TabIndex = 7;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divideButtton
            // 
            this.divideButtton.Location = new System.Drawing.Point(54, 398);
            this.divideButtton.Name = "divideButtton";
            this.divideButtton.Size = new System.Drawing.Size(108, 43);
            this.divideButtton.TabIndex = 8;
            this.divideButtton.Text = "Divide";
            this.divideButtton.UseVisualStyleBackColor = true;
            this.divideButtton.Click += new System.EventHandler(this.divideButtton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 9;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(216, 300);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(81, 29);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "Result";
            // 
            // resultValue
            // 
            this.resultValue.Location = new System.Drawing.Point(178, 337);
            this.resultValue.Name = "resultValue";
            this.resultValue.Size = new System.Drawing.Size(149, 30);
            this.resultValue.TabIndex = 11;
            // 
            // productDataLabel
            // 
            this.productDataLabel.AutoSize = true;
            this.productDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDataLabel.Location = new System.Drawing.Point(741, 19);
            this.productDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productDataLabel.Name = "productDataLabel";
            this.productDataLabel.Size = new System.Drawing.Size(180, 32);
            this.productDataLabel.TabIndex = 12;
            this.productDataLabel.Text = "Product Data";
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(598, 116);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(89, 25);
            this.productsLabel.TabIndex = 13;
            this.productsLabel.Text = "Products";
            // 
            // productsDropdown
            // 
            this.productsDropdown.FormattingEnabled = true;
            this.productsDropdown.Location = new System.Drawing.Point(697, 108);
            this.productsDropdown.Name = "productsDropdown";
            this.productsDropdown.Size = new System.Drawing.Size(302, 33);
            this.productsDropdown.TabIndex = 14;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(598, 246);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(131, 25);
            this.productNameLabel.TabIndex = 15;
            this.productNameLabel.Text = "ProductName";
            // 
            // productNameValue
            // 
            this.productNameValue.Location = new System.Drawing.Point(736, 241);
            this.productNameValue.Name = "productNameValue";
            this.productNameValue.Size = new System.Drawing.Size(263, 30);
            this.productNameValue.TabIndex = 16;
            // 
            // priceValue
            // 
            this.priceValue.Location = new System.Drawing.Point(736, 300);
            this.priceValue.Name = "priceValue";
            this.priceValue.Size = new System.Drawing.Size(263, 30);
            this.priceValue.TabIndex = 18;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(598, 304);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(56, 25);
            this.priceLabel.TabIndex = 17;
            this.priceLabel.Text = "Price";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(189, 398);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(108, 43);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // quantityValue
            // 
            this.quantityValue.Location = new System.Drawing.Point(736, 362);
            this.quantityValue.Name = "quantityValue";
            this.quantityValue.Size = new System.Drawing.Size(263, 30);
            this.quantityValue.TabIndex = 21;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(598, 366);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(85, 25);
            this.quantityLabel.TabIndex = 20;
            this.quantityLabel.Text = "Quantity";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addproductButton
            // 
            this.addproductButton.Location = new System.Drawing.Point(793, 426);
            this.addproductButton.Name = "addproductButton";
            this.addproductButton.Size = new System.Drawing.Size(148, 43);
            this.addproductButton.TabIndex = 22;
            this.addproductButton.Text = "Add Product";
            this.addproductButton.UseVisualStyleBackColor = true;
            this.addproductButton.Click += new System.EventHandler(this.addproductButton_Click);
            // 
            // clearProductButton
            // 
            this.clearProductButton.Location = new System.Drawing.Point(813, 486);
            this.clearProductButton.Name = "clearProductButton";
            this.clearProductButton.Size = new System.Drawing.Size(108, 43);
            this.clearProductButton.TabIndex = 23;
            this.clearProductButton.Text = "Clear";
            this.clearProductButton.UseVisualStyleBackColor = true;
            this.clearProductButton.Click += new System.EventHandler(this.clearProductButton_Click);
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.clearProductButton);
            this.Controls.Add(this.addproductButton);
            this.Controls.Add(this.quantityValue);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.priceValue);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.productNameValue);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productsDropdown);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.productDataLabel);
            this.Controls.Add(this.resultValue);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divideButtton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.yValue);
            this.Controls.Add(this.xValue);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.calculatorLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Demo";
            this.Text = "Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label calculatorLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.TextBox xValue;
        private System.Windows.Forms.TextBox yValue;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divideButtton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultValue;
        private System.Windows.Forms.Label productDataLabel;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.ComboBox productsDropdown;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox productNameValue;
        private System.Windows.Forms.TextBox priceValue;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox quantityValue;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Button addproductButton;
        private System.Windows.Forms.Button clearProductButton;
    }
}


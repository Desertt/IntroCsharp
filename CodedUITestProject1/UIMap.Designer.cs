﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Hesaplama Butonuna Basılır
        /// </summary>
        public void HesaplaButonaBas()
        {
            #region Variable Declarations
            WinWindow uIHesaplaWindow = this.UIForm1Window.UIForm1Client.UIHesaplaWindow;
            #endregion

            // Click 'Hesapla' window
            Mouse.Click(uIHesaplaWindow, new Point(144, 165));
        }
        
        /// <summary>
        /// İsşlem türü seçilir.
        /// </summary>
        public void İslemSec()
        {
            #region Variable Declarations
            WinWindow uIComboBox1Window = this.UIForm1Window.UIForm1Client.UIComboBox1Window;
            WinComboBox uISayi2ComboBox = this.UIForm1Window.UIComboBox1Window.UISayi2ComboBox;
            #endregion

            // Click 'comboBox1' window
            Mouse.Click(uIComboBox1Window, new Point(186, 127));

            // Select 'Çıkar' in 'Sayi2' combo box
            uISayi2ComboBox.SelectedItem = this.İslemSecParams.UISayi2ComboBoxSelectedItem;
        }
        
        /// <summary>
        /// Sonuc
        /// </summary>
        public void islemSonuc()
        {
            #region Variable Declarations
            WinWindow uITxtSayi1Window = this.UIForm1Window.UIForm1Client.UITxtSayi1Window;
            WinWindow uITxtSayi2Window = this.UIForm1Window.UIForm1Client.UITxtSayi2Window;
            WinEdit uITxtSayi2Edit = this.UIForm1Window.UITxtSayi2Window.UITxtSayi2Edit;
            WinComboBox uISayi2ComboBox = this.UIForm1Window.UIComboBox1Window.UISayi2ComboBox;
            WinButton uITıklayınızButton = this.UIForm1Window.UITıklayınızWindow.UITıklayınızButton;
            WinButton uIHesaplaButton = this.UIForm1Window.UIHesaplaWindow.UIHesaplaButton;
            #endregion

            // Click 'txtSayi1' window
            Mouse.Click(uITxtSayi1Window, new Point(64, 66));

            // Click 'txtSayi2' window
            Mouse.Click(uITxtSayi2Window, new Point(63, 77));

            // Type '{Tab}' in 'txtSayi2' text box
            Keyboard.SendKeys(uITxtSayi2Edit, this.islemSonucParams.UITxtSayi2EditSendKeys, ModifierKeys.None);

            // Select 'Topla' in 'Sayi2' combo box
            uISayi2ComboBox.SelectedItem = this.islemSonucParams.UISayi2ComboBoxSelectedItem;

            // Type '{Tab}' in 'Sayi2' combo box
            Keyboard.SendKeys(uISayi2ComboBox, this.islemSonucParams.UISayi2ComboBoxSendKeys, ModifierKeys.None);

            // Type '{Tab}' in 'Tıklayınız' button
            Keyboard.SendKeys(uITıklayınızButton, this.islemSonucParams.UITıklayınızButtonSendKeys, ModifierKeys.None);

            // Type '{Enter}' in 'Hesapla' button
            Keyboard.SendKeys(uIHesaplaButton, this.islemSonucParams.UIHesaplaButtonSendKeys, ModifierKeys.None);
        }
        
        /// <summary>
        /// Sayı 1 Girilir
        /// </summary>
        public void Sayi1Gir()
        {
            #region Variable Declarations
            WinWindow uITxtSayi1Window = this.UIForm1Window.UIForm1Client.UITxtSayi1Window;
            WinEdit uITxtSayi1Edit = this.UIForm1Window.UITxtSayi1Window.UITxtSayi1Edit;
            #endregion

            // Click 'txtSayi1' window
            Mouse.Click(uITxtSayi1Window, new Point(125, 116));

            // Type '5' in 'txtSayi1' text box
            uITxtSayi1Edit.Text = this.Sayi1GirParams.UITxtSayi1EditText;
        }
        
        /// <summary>
        /// Sayı 2 Girilir
        /// </summary>
        public void Sayi2gir()
        {
            #region Variable Declarations
            WinWindow uITxtSayi2Window = this.UIForm1Window.UIForm1Client.UITxtSayi2Window;
            WinEdit uITxtSayi2Edit = this.UIForm1Window.UITxtSayi2Window.UITxtSayi2Edit;
            #endregion

            // Click 'txtSayi2' window
            Mouse.Click(uITxtSayi2Window, new Point(127, 116));

            // Type '2' in 'txtSayi2' text box
            uITxtSayi2Edit.Text = this.Sayi2girParams.UITxtSayi2EditText;
        }
        
        /// <summary>
        /// uygulamaac
        /// </summary>
        public void Uygulamaac()
        {

            // Launch 'F:\CSHARP\AllAppRepos\Desertt\IntroCsharp\IntroCsharp\bin\Debug\IntroCsharp.exe'
            ApplicationUnderTest introCsharpApplication = ApplicationUnderTest.Launch(this.UygulamaacParams.ExePath, this.UygulamaacParams.AlternateExePath);
        }
        
        /// <summary>
        /// Uygulama Açılır
        /// </summary>
        public void UygulamayiAc()
        {

            // Launch 'F:\CSHARP\AllAppRepos\Desertt\IntroCsharp\IntroCsharp\bin\Debug\IntroCsharp.exe'
            ApplicationUnderTest introCsharpApplication = ApplicationUnderTest.Launch(this.UygulamayiAcParams.ExePath, this.UygulamayiAcParams.AlternateExePath);
        }
        
        #region Properties
        public virtual İslemSecParams İslemSecParams
        {
            get
            {
                if ((this.mİslemSecParams == null))
                {
                    this.mİslemSecParams = new İslemSecParams();
                }
                return this.mİslemSecParams;
            }
        }
        
        public virtual islemSonucParams islemSonucParams
        {
            get
            {
                if ((this.mislemSonucParams == null))
                {
                    this.mislemSonucParams = new islemSonucParams();
                }
                return this.mislemSonucParams;
            }
        }
        
        public virtual Sayi1GirParams Sayi1GirParams
        {
            get
            {
                if ((this.mSayi1GirParams == null))
                {
                    this.mSayi1GirParams = new Sayi1GirParams();
                }
                return this.mSayi1GirParams;
            }
        }
        
        public virtual Sayi2girParams Sayi2girParams
        {
            get
            {
                if ((this.mSayi2girParams == null))
                {
                    this.mSayi2girParams = new Sayi2girParams();
                }
                return this.mSayi2girParams;
            }
        }
        
        public virtual UygulamaacParams UygulamaacParams
        {
            get
            {
                if ((this.mUygulamaacParams == null))
                {
                    this.mUygulamaacParams = new UygulamaacParams();
                }
                return this.mUygulamaacParams;
            }
        }
        
        public virtual UygulamayiAcParams UygulamayiAcParams
        {
            get
            {
                if ((this.mUygulamayiAcParams == null))
                {
                    this.mUygulamayiAcParams = new UygulamayiAcParams();
                }
                return this.mUygulamayiAcParams;
            }
        }
        
        public UIForm1Window UIForm1Window
        {
            get
            {
                if ((this.mUIForm1Window == null))
                {
                    this.mUIForm1Window = new UIForm1Window();
                }
                return this.mUIForm1Window;
            }
        }
        #endregion
        
        #region Fields
        private İslemSecParams mİslemSecParams;
        
        private islemSonucParams mislemSonucParams;
        
        private Sayi1GirParams mSayi1GirParams;
        
        private Sayi2girParams mSayi2girParams;
        
        private UygulamaacParams mUygulamaacParams;
        
        private UygulamayiAcParams mUygulamayiAcParams;
        
        private UIForm1Window mUIForm1Window;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'İslemSec'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class İslemSecParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'Çıkar' in 'Sayi2' combo box
        /// </summary>
        public string UISayi2ComboBoxSelectedItem = "Çıkar";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'islemSonuc'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class islemSonucParams
    {
        
        #region Fields
        /// <summary>
        /// Type '{Tab}' in 'txtSayi2' text box
        /// </summary>
        public string UITxtSayi2EditSendKeys = "{Tab}";
        
        /// <summary>
        /// Select 'Topla' in 'Sayi2' combo box
        /// </summary>
        public string UISayi2ComboBoxSelectedItem = "Topla";
        
        /// <summary>
        /// Type '{Tab}' in 'Sayi2' combo box
        /// </summary>
        public string UISayi2ComboBoxSendKeys = "{Tab}";
        
        /// <summary>
        /// Type '{Tab}' in 'Tıklayınız' button
        /// </summary>
        public string UITıklayınızButtonSendKeys = "{Tab}";
        
        /// <summary>
        /// Type '{Enter}' in 'Hesapla' button
        /// </summary>
        public string UIHesaplaButtonSendKeys = "{Enter}";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Sayi1Gir'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class Sayi1GirParams
    {
        
        #region Fields
        /// <summary>
        /// Type '5' in 'txtSayi1' text box
        /// </summary>
        public string UITxtSayi1EditText = "5";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Sayi2gir'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class Sayi2girParams
    {
        
        #region Fields
        /// <summary>
        /// Type '2' in 'txtSayi2' text box
        /// </summary>
        public string UITxtSayi2EditText = "2";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'Uygulamaac'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UygulamaacParams
    {
        
        #region Fields
        /// <summary>
        /// Launch 'F:\CSHARP\AllAppRepos\Desertt\IntroCsharp\IntroCsharp\bin\Debug\IntroCsharp.exe'
        /// </summary>
        public string ExePath = "F:\\CSHARP\\AllAppRepos\\Desertt\\IntroCsharp\\IntroCsharp\\bin\\Debug\\IntroCsharp.exe";
        
        /// <summary>
        /// Launch 'F:\CSHARP\AllAppRepos\Desertt\IntroCsharp\IntroCsharp\bin\Debug\IntroCsharp.exe'
        /// </summary>
        public string AlternateExePath = "F:\\CSHARP\\AllAppRepos\\Desertt\\IntroCsharp\\IntroCsharp\\bin\\Debug\\IntroCsharp.exe";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'UygulamayiAc'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UygulamayiAcParams
    {
        
        #region Fields
        /// <summary>
        /// Launch 'F:\CSHARP\AllAppRepos\Desertt\IntroCsharp\IntroCsharp\bin\Debug\IntroCsharp.exe'
        /// </summary>
        public string ExePath = "F:\\CSHARP\\AllAppRepos\\Desertt\\IntroCsharp\\IntroCsharp\\bin\\Debug\\IntroCsharp.exe";
        
        /// <summary>
        /// Launch 'F:\CSHARP\AllAppRepos\Desertt\IntroCsharp\IntroCsharp\bin\Debug\IntroCsharp.exe'
        /// </summary>
        public string AlternateExePath = "F:\\CSHARP\\AllAppRepos\\Desertt\\IntroCsharp\\IntroCsharp\\bin\\Debug\\IntroCsharp.exe";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIForm1Window : WinWindow
    {
        
        public UIForm1Window()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Form1";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public UIForm1Client UIForm1Client
        {
            get
            {
                if ((this.mUIForm1Client == null))
                {
                    this.mUIForm1Client = new UIForm1Client(this);
                }
                return this.mUIForm1Client;
            }
        }
        
        public UITxtSayi1Window UITxtSayi1Window
        {
            get
            {
                if ((this.mUITxtSayi1Window == null))
                {
                    this.mUITxtSayi1Window = new UITxtSayi1Window(this);
                }
                return this.mUITxtSayi1Window;
            }
        }
        
        public UITxtSayi2Window UITxtSayi2Window
        {
            get
            {
                if ((this.mUITxtSayi2Window == null))
                {
                    this.mUITxtSayi2Window = new UITxtSayi2Window(this);
                }
                return this.mUITxtSayi2Window;
            }
        }
        
        public UIComboBox1Window UIComboBox1Window
        {
            get
            {
                if ((this.mUIComboBox1Window == null))
                {
                    this.mUIComboBox1Window = new UIComboBox1Window(this);
                }
                return this.mUIComboBox1Window;
            }
        }
        
        public UITıklayınızWindow UITıklayınızWindow
        {
            get
            {
                if ((this.mUITıklayınızWindow == null))
                {
                    this.mUITıklayınızWindow = new UITıklayınızWindow(this);
                }
                return this.mUITıklayınızWindow;
            }
        }
        
        public UIHesaplaWindow UIHesaplaWindow
        {
            get
            {
                if ((this.mUIHesaplaWindow == null))
                {
                    this.mUIHesaplaWindow = new UIHesaplaWindow(this);
                }
                return this.mUIHesaplaWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIForm1Client mUIForm1Client;
        
        private UITxtSayi1Window mUITxtSayi1Window;
        
        private UITxtSayi2Window mUITxtSayi2Window;
        
        private UIComboBox1Window mUIComboBox1Window;
        
        private UITıklayınızWindow mUITıklayınızWindow;
        
        private UIHesaplaWindow mUIHesaplaWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIForm1Client : WinClient
    {
        
        public UIForm1Client(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Form1";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinWindow UITxtSayi1Window
        {
            get
            {
                if ((this.mUITxtSayi1Window == null))
                {
                    this.mUITxtSayi1Window = new WinWindow(this);
                    #region Search Criteria
                    this.mUITxtSayi1Window.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.EDIT", PropertyExpressionOperator.Contains));
                    this.mUITxtSayi1Window.SearchProperties[WinWindow.PropertyNames.Instance] = "2";
                    this.mUITxtSayi1Window.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUITxtSayi1Window;
            }
        }
        
        public WinWindow UITxtSayi2Window
        {
            get
            {
                if ((this.mUITxtSayi2Window == null))
                {
                    this.mUITxtSayi2Window = new WinWindow(this);
                    #region Search Criteria
                    this.mUITxtSayi2Window.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.EDIT", PropertyExpressionOperator.Contains));
                    this.mUITxtSayi2Window.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUITxtSayi2Window;
            }
        }
        
        public WinWindow UIComboBox1Window
        {
            get
            {
                if ((this.mUIComboBox1Window == null))
                {
                    this.mUIComboBox1Window = new WinWindow(this);
                    #region Search Criteria
                    this.mUIComboBox1Window.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Sayi2";
                    this.mUIComboBox1Window.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.COMBOBOX", PropertyExpressionOperator.Contains));
                    this.mUIComboBox1Window.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUIComboBox1Window;
            }
        }
        
        public WinWindow UIHesaplaWindow
        {
            get
            {
                if ((this.mUIHesaplaWindow == null))
                {
                    this.mUIHesaplaWindow = new WinWindow(this);
                    #region Search Criteria
                    this.mUIHesaplaWindow.SearchProperties[WinWindow.PropertyNames.Name] = "Hesapla";
                    this.mUIHesaplaWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.BUTTON", PropertyExpressionOperator.Contains));
                    this.mUIHesaplaWindow.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUIHesaplaWindow;
            }
        }
        #endregion
        
        #region Fields
        private WinWindow mUITxtSayi1Window;
        
        private WinWindow mUITxtSayi2Window;
        
        private WinWindow mUIComboBox1Window;
        
        private WinWindow mUIHesaplaWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UITxtSayi1Window : WinWindow
    {
        
        public UITxtSayi1Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtSayi1";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtSayi1Edit
        {
            get
            {
                if ((this.mUITxtSayi1Edit == null))
                {
                    this.mUITxtSayi1Edit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtSayi1Edit.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUITxtSayi1Edit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtSayi1Edit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UITxtSayi2Window : WinWindow
    {
        
        public UITxtSayi2Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtSayi2";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtSayi2Edit
        {
            get
            {
                if ((this.mUITxtSayi2Edit == null))
                {
                    this.mUITxtSayi2Edit = new WinEdit(this);
                    #region Search Criteria
                    this.mUITxtSayi2Edit.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUITxtSayi2Edit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtSayi2Edit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIComboBox1Window : WinWindow
    {
        
        public UIComboBox1Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "comboBox1";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinComboBox UISayi2ComboBox
        {
            get
            {
                if ((this.mUISayi2ComboBox == null))
                {
                    this.mUISayi2ComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUISayi2ComboBox.SearchProperties[WinComboBox.PropertyNames.Name] = "Sayi2";
                    this.mUISayi2ComboBox.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUISayi2ComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinComboBox mUISayi2ComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UITıklayınızWindow : WinWindow
    {
        
        public UITıklayınızWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "button1";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinButton UITıklayınızButton
        {
            get
            {
                if ((this.mUITıklayınızButton == null))
                {
                    this.mUITıklayınızButton = new WinButton(this);
                    #region Search Criteria
                    this.mUITıklayınızButton.SearchProperties[WinButton.PropertyNames.Name] = "Tıklayınız";
                    this.mUITıklayınızButton.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUITıklayınızButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUITıklayınızButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIHesaplaWindow : WinWindow
    {
        
        public UIHesaplaWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnHesapla";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinButton UIHesaplaButton
        {
            get
            {
                if ((this.mUIHesaplaButton == null))
                {
                    this.mUIHesaplaButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIHesaplaButton.SearchProperties[WinButton.PropertyNames.Name] = "Hesapla";
                    this.mUIHesaplaButton.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUIHesaplaButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIHesaplaButton;
        #endregion
    }
}

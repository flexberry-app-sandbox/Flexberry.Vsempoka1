﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Vsempoka
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Товары.
    /// </summary>
    // *** Start programmer edit section *** (Товары CustomAttributes)

    // *** End programmer edit section *** (Товары CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ТоварыE", new string[] {
            "НаимТовара as \'Наименование товара\'",
            "Производитель as \'Производитель\'",
            "ЕдиницыИзмер as \'Единицы измерения\'",
            "Цены as \'Цены\'",
            "Масса as \'Масса\'"})]
    [View("ТоварыL", new string[] {
            "НаимТовара as \'Наименование товара\'",
            "Производитель as \'Производитель\'",
            "ЕдиницыИзмер as \'Единицы измерения\'",
            "Цены as \'Цены\'",
            "Масса as \'Масса\'"})]
    public class Товары : ICSSoft.STORMNET.DataObject
    {
        
        private string fНаимТовара;
        
        private string fПроизводитель;
        
        private IIS.Vsempoka.ЕдИзмер fЕдиницыИзмер;
        
        private int fЦены;
        
        private int fМасса;
        
        // *** Start programmer edit section *** (Товары CustomMembers)

        // *** End programmer edit section *** (Товары CustomMembers)

        
        /// <summary>
        /// ЕдиницыИзмер.
        /// </summary>
        // *** Start programmer edit section *** (Товары.ЕдиницыИзмер CustomAttributes)

        // *** End programmer edit section *** (Товары.ЕдиницыИзмер CustomAttributes)
        public virtual IIS.Vsempoka.ЕдИзмер ЕдиницыИзмер
        {
            get
            {
                // *** Start programmer edit section *** (Товары.ЕдиницыИзмер Get start)

                // *** End programmer edit section *** (Товары.ЕдиницыИзмер Get start)
                IIS.Vsempoka.ЕдИзмер result = this.fЕдиницыИзмер;
                // *** Start programmer edit section *** (Товары.ЕдиницыИзмер Get end)

                // *** End programmer edit section *** (Товары.ЕдиницыИзмер Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Товары.ЕдиницыИзмер Set start)

                // *** End programmer edit section *** (Товары.ЕдиницыИзмер Set start)
                this.fЕдиницыИзмер = value;
                // *** Start programmer edit section *** (Товары.ЕдиницыИзмер Set end)

                // *** End programmer edit section *** (Товары.ЕдиницыИзмер Set end)
            }
        }
        
        /// <summary>
        /// Масса.
        /// </summary>
        // *** Start programmer edit section *** (Товары.Масса CustomAttributes)

        // *** End programmer edit section *** (Товары.Масса CustomAttributes)
        public virtual int Масса
        {
            get
            {
                // *** Start programmer edit section *** (Товары.Масса Get start)

                // *** End programmer edit section *** (Товары.Масса Get start)
                int result = this.fМасса;
                // *** Start programmer edit section *** (Товары.Масса Get end)

                // *** End programmer edit section *** (Товары.Масса Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Товары.Масса Set start)

                // *** End programmer edit section *** (Товары.Масса Set start)
                this.fМасса = value;
                // *** Start programmer edit section *** (Товары.Масса Set end)

                // *** End programmer edit section *** (Товары.Масса Set end)
            }
        }
        
        /// <summary>
        /// НаимТовара.
        /// </summary>
        // *** Start programmer edit section *** (Товары.НаимТовара CustomAttributes)

        // *** End programmer edit section *** (Товары.НаимТовара CustomAttributes)
        [StrLen(255)]
        public virtual string НаимТовара
        {
            get
            {
                // *** Start programmer edit section *** (Товары.НаимТовара Get start)

                // *** End programmer edit section *** (Товары.НаимТовара Get start)
                string result = this.fНаимТовара;
                // *** Start programmer edit section *** (Товары.НаимТовара Get end)

                // *** End programmer edit section *** (Товары.НаимТовара Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Товары.НаимТовара Set start)

                // *** End programmer edit section *** (Товары.НаимТовара Set start)
                this.fНаимТовара = value;
                // *** Start programmer edit section *** (Товары.НаимТовара Set end)

                // *** End programmer edit section *** (Товары.НаимТовара Set end)
            }
        }
        
        /// <summary>
        /// Производитель.
        /// </summary>
        // *** Start programmer edit section *** (Товары.Производитель CustomAttributes)

        // *** End programmer edit section *** (Товары.Производитель CustomAttributes)
        [StrLen(255)]
        public virtual string Производитель
        {
            get
            {
                // *** Start programmer edit section *** (Товары.Производитель Get start)

                // *** End programmer edit section *** (Товары.Производитель Get start)
                string result = this.fПроизводитель;
                // *** Start programmer edit section *** (Товары.Производитель Get end)

                // *** End programmer edit section *** (Товары.Производитель Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Товары.Производитель Set start)

                // *** End programmer edit section *** (Товары.Производитель Set start)
                this.fПроизводитель = value;
                // *** Start programmer edit section *** (Товары.Производитель Set end)

                // *** End programmer edit section *** (Товары.Производитель Set end)
            }
        }
        
        /// <summary>
        /// Цены.
        /// </summary>
        // *** Start programmer edit section *** (Товары.Цены CustomAttributes)

        // *** End programmer edit section *** (Товары.Цены CustomAttributes)
        public virtual int Цены
        {
            get
            {
                // *** Start programmer edit section *** (Товары.Цены Get start)

                // *** End programmer edit section *** (Товары.Цены Get start)
                int result = this.fЦены;
                // *** Start programmer edit section *** (Товары.Цены Get end)

                // *** End programmer edit section *** (Товары.Цены Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Товары.Цены Set start)

                // *** End programmer edit section *** (Товары.Цены Set start)
                this.fЦены = value;
                // *** Start programmer edit section *** (Товары.Цены Set end)

                // *** End programmer edit section *** (Товары.Цены Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ТоварыE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТоварыE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТоварыE", typeof(IIS.Vsempoka.Товары));
                }
            }
            
            /// <summary>
            /// "ТоварыL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ТоварыL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ТоварыL", typeof(IIS.Vsempoka.Товары));
                }
            }
        }
    }
}

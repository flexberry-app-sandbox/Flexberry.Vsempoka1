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
    /// Инфор о заказе.
    /// </summary>
    // *** Start programmer edit section *** (ИнфорОЗаказе CustomAttributes)

    // *** End programmer edit section *** (ИнфорОЗаказе CustomAttributes)
    [AutoAltered()]
    [Caption("Информация о заказе")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ИнфорОЗаказеE", new string[] {
            "Товары as \'Наименование товара\'",
            "Товары.НаимТовара as \'Наименование товара\'",
            "Количество as \'Количество\'",
            "Товары.ЕдиницыИзмер as \'Единицы измерения\'",
            "Товары.Масса as \'Масса\'",
            "Товары.Цены as \'Цена\'"}, Hidden=new string[] {
            "Товары.НаимТовара"})]
    [MasterViewDefineAttribute("ИнфорОЗаказеE", "Товары", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "НаимТовара")]
    public class ИнфорОЗаказе : ICSSoft.STORMNET.DataObject
    {
        
        private int fКоличество;
        
        private IIS.Vsempoka.Товары fТовары;
        
        private IIS.Vsempoka.ДокумПостав fДокумПостав;
        
        // *** Start programmer edit section *** (ИнфорОЗаказе CustomMembers)

        // *** End programmer edit section *** (ИнфорОЗаказе CustomMembers)

        
        /// <summary>
        /// Количество.
        /// </summary>
        // *** Start programmer edit section *** (ИнфорОЗаказе.Количество CustomAttributes)

        // *** End programmer edit section *** (ИнфорОЗаказе.Количество CustomAttributes)
        public virtual int Количество
        {
            get
            {
                // *** Start programmer edit section *** (ИнфорОЗаказе.Количество Get start)

                // *** End programmer edit section *** (ИнфорОЗаказе.Количество Get start)
                int result = this.fКоличество;
                // *** Start programmer edit section *** (ИнфорОЗаказе.Количество Get end)

                // *** End programmer edit section *** (ИнфорОЗаказе.Количество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИнфорОЗаказе.Количество Set start)

                // *** End programmer edit section *** (ИнфорОЗаказе.Количество Set start)
                this.fКоличество = value;
                // *** Start programmer edit section *** (ИнфорОЗаказе.Количество Set end)

                // *** End programmer edit section *** (ИнфорОЗаказе.Количество Set end)
            }
        }
        
        /// <summary>
        /// Инфор о заказе.
        /// </summary>
        // *** Start programmer edit section *** (ИнфорОЗаказе.Товары CustomAttributes)

        // *** End programmer edit section *** (ИнфорОЗаказе.Товары CustomAttributes)
        [PropertyStorage(new string[] {
                "Товары"})]
        [NotNull()]
        public virtual IIS.Vsempoka.Товары Товары
        {
            get
            {
                // *** Start programmer edit section *** (ИнфорОЗаказе.Товары Get start)

                // *** End programmer edit section *** (ИнфорОЗаказе.Товары Get start)
                IIS.Vsempoka.Товары result = this.fТовары;
                // *** Start programmer edit section *** (ИнфорОЗаказе.Товары Get end)

                // *** End programmer edit section *** (ИнфорОЗаказе.Товары Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИнфорОЗаказе.Товары Set start)

                // *** End programmer edit section *** (ИнфорОЗаказе.Товары Set start)
                this.fТовары = value;
                // *** Start programmer edit section *** (ИнфорОЗаказе.Товары Set end)

                // *** End programmer edit section *** (ИнфорОЗаказе.Товары Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.Vsempoka.ДокумПостав.
        /// </summary>
        // *** Start programmer edit section *** (ИнфорОЗаказе.ДокумПостав CustomAttributes)

        // *** End programmer edit section *** (ИнфорОЗаказе.ДокумПостав CustomAttributes)
        [Agregator()]
        [NotNull()]
        [PropertyStorage(new string[] {
                "ДокумПостав"})]
        public virtual IIS.Vsempoka.ДокумПостав ДокумПостав
        {
            get
            {
                // *** Start programmer edit section *** (ИнфорОЗаказе.ДокумПостав Get start)

                // *** End programmer edit section *** (ИнфорОЗаказе.ДокумПостав Get start)
                IIS.Vsempoka.ДокумПостав result = this.fДокумПостав;
                // *** Start programmer edit section *** (ИнфорОЗаказе.ДокумПостав Get end)

                // *** End programmer edit section *** (ИнфорОЗаказе.ДокумПостав Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (ИнфорОЗаказе.ДокумПостав Set start)

                // *** End programmer edit section *** (ИнфорОЗаказе.ДокумПостав Set start)
                this.fДокумПостав = value;
                // *** Start programmer edit section *** (ИнфорОЗаказе.ДокумПостав Set end)

                // *** End programmer edit section *** (ИнфорОЗаказе.ДокумПостав Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ИнфорОЗаказеE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ИнфорОЗаказеE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ИнфорОЗаказеE", typeof(IIS.Vsempoka.ИнфорОЗаказе));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ИнфорОЗаказе.
    /// </summary>
    // *** Start programmer edit section *** (DetailArrayDetailArrayOfИнфорОЗаказе CustomAttributes)

    // *** End programmer edit section *** (DetailArrayDetailArrayOfИнфорОЗаказе CustomAttributes)
    public class DetailArrayOfИнфорОЗаказе : ICSSoft.STORMNET.DetailArray
    {
        
        // *** Start programmer edit section *** (IIS.Vsempoka.DetailArrayOfИнфорОЗаказе members)

        // *** End programmer edit section *** (IIS.Vsempoka.DetailArrayOfИнфорОЗаказе members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ИнфорОЗаказе by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ИнфорОЗаказе.
        /// </summary>
        public DetailArrayOfИнфорОЗаказе(IIS.Vsempoka.ДокумПостав fДокумПостав) : 
                base(typeof(ИнфорОЗаказе), ((ICSSoft.STORMNET.DataObject)(fДокумПостав)))
        {
        }
        
        public IIS.Vsempoka.ИнфорОЗаказе this[int index]
        {
            get
            {
                return ((IIS.Vsempoka.ИнфорОЗаказе)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.Vsempoka.ИнфорОЗаказе dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}

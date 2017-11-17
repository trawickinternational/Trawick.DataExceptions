using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Trawick.DataExceptions.Configuration
{
    public class DataExceptionTypeElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
        public string Name
        {
            get { return (string)base["name"]; }
        }

        [ConfigurationProperty("type", IsRequired = false)]
        public string Type
        {
            get { return (string)base["type"]; }
        }
    }

    [ConfigurationCollection(typeof(DataExceptionTypeElement))]
    public class DataExceptionTypeElementCollection : ConfigurationElementCollection
    {
        internal const string PropertyName = "exceptiontype";

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMapAlternate;
            }
        }
        protected override string ElementName
        {
            get
            {
                return PropertyName;
            }
        }

        protected override bool IsElementName(string elementName)
        {
            return elementName.Equals(PropertyName,
              StringComparison.InvariantCultureIgnoreCase);
        }

        public override bool IsReadOnly()
        {
            return false;
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new DataExceptionTypeElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((DataExceptionTypeElement)(element)).Name;
        }

        public DataExceptionTypeElement this[int idx]
        {
            get { return (DataExceptionTypeElement)BaseGet(idx); }
        }
    }

    public class DataExceptionTypesSection : ConfigurationSection
    {
        [ConfigurationProperty("exceptiontypes")]
        public DataExceptionTypeElementCollection ExceptionTypes
        {
            get { return ((DataExceptionTypeElementCollection)(base["exceptiontypes"])); }
            set { base["exceptiontypes"] = value; }
        }
    }
}

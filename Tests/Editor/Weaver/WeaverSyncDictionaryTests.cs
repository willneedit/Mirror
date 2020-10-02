using NUnit.Framework;

namespace Mirror.Weaver.Tests
{
    // Some tests for SyncObjects are in WeaverSyncListTests and apply to SyncDictionary too
    public class WeaverSyncDictionaryTests : WeaverTestsBuildFromTestName
    {
        [Test]
        public void SyncDictionary()
        {
            IsSuccess();
        }

        [Test]
        public void SyncDictionaryGenericAbstractInheritance()
        {
            IsSuccess();
        }

        [Test]
        public void SyncDictionaryGenericInheritance()
        {
            IsSuccess();
        }

        [Test]
        public void SyncDictionaryInheritance()
        {
            IsSuccess();
        }

        [Test]
        public void SyncDictionaryStructKey()
        {
            IsSuccess();
        }

        [Test]
        public void SyncDictionaryStructItem()
        {
            IsSuccess();
        }

        [Test]
        public void SyncDictionaryErrorForGenericStructKey()
        {
            HasError("Cannot generate reader for generic variable MyGenericStruct`1. Use a supported type or provide a custom reader",
                "WeaverSyncDictionaryTests.SyncDictionaryErrorForGenericStructKey.SyncDictionaryErrorForGenericStructKey/MyGenericStruct`1<System.Single>");
            HasError("Cannot generate writer for generic type MyGenericStruct`1. Use a supported type or provide a custom writer",
                "WeaverSyncDictionaryTests.SyncDictionaryErrorForGenericStructKey.SyncDictionaryErrorForGenericStructKey/MyGenericStruct`1<System.Single>");
        }

        [Test]
        public void SyncDictionaryErrorForGenericStructItem()
        {
            HasError("Cannot generate reader for generic variable MyGenericStruct`1. Use a supported type or provide a custom reader",
                "WeaverSyncDictionaryTests.SyncDictionaryErrorForGenericStructItem.SyncDictionaryErrorForGenericStructItem/MyGenericStruct`1<System.Single>");
            HasError("Cannot generate writer for generic type MyGenericStruct`1. Use a supported type or provide a custom writer",
                "WeaverSyncDictionaryTests.SyncDictionaryErrorForGenericStructItem.SyncDictionaryErrorForGenericStructItem/MyGenericStruct`1<System.Single>");
        }

        [Test]
        public void SyncDictionaryGenericStructKeyWithCustomMethods()
        {
            IsSuccess();
        }

        [Test]
        public void SyncDictionaryGenericStructItemWithCustomMethods()
        {
            IsSuccess();
        }

        [Test]
        public void SyncDictionaryErrorWhenUsingGenericInNetworkBehaviour()
        {
            IsSuccess();
        }
    }
}

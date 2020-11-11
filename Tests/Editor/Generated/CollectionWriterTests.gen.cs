// Generated by CollectionWriterGenerator.cs
using System;
using System.Collections.Generic;
using Mirror.Tests.Generators;
using NUnit.Framework;
using UnityEngine;

namespace Mirror.Tests.Generated.CollectionWriters
{

    public class Array_int_Test
    {
        public struct Message : NetworkMessage
        {
            public int[] collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            int[] unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            Message message = new Message
            {
                collection = new int[] { }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            int[] unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsEmpty(unpackedCollection);
        }

        [Test]
        public void SendsData()
        {
            Message message = new Message
            {
                collection = new int[]
                {
                    3, 4, 5
                }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            int[] unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsNotEmpty(unpackedCollection);
            Assert.That(unpackedCollection[0], Is.EqualTo(3));
            Assert.That(unpackedCollection[1], Is.EqualTo(4));
            Assert.That(unpackedCollection[2], Is.EqualTo(5));
        }
    }

    public class Array_string_Test
    {
        public struct Message : NetworkMessage
        {
            public string[] collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            string[] unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            Message message = new Message
            {
                collection = new string[] { }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            string[] unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsEmpty(unpackedCollection);
        }

        [Test]
        public void SendsData()
        {
            Message message = new Message
            {
                collection = new string[]
                {
                    "Some", "String", "Value"
                }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            string[] unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsNotEmpty(unpackedCollection);
            Assert.That(unpackedCollection[0], Is.EqualTo("Some"));
            Assert.That(unpackedCollection[1], Is.EqualTo("String"));
            Assert.That(unpackedCollection[2], Is.EqualTo("Value"));
        }
    }

    public class Array_Vector3_Test
    {
        public struct Message : NetworkMessage
        {
            public Vector3[] collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            Vector3[] unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            Message message = new Message
            {
                collection = new Vector3[] { }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            Vector3[] unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsEmpty(unpackedCollection);
        }

        [Test]
        public void SendsData()
        {
            Message message = new Message
            {
                collection = new Vector3[]
                {
                    new Vector3(1, 2, 3), new Vector3(4, 5, 6), new Vector3(7, 8, 9)
                }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            Vector3[] unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsNotEmpty(unpackedCollection);
            Assert.That(unpackedCollection[0], Is.EqualTo(new Vector3(1, 2, 3)));
            Assert.That(unpackedCollection[1], Is.EqualTo(new Vector3(4, 5, 6)));
            Assert.That(unpackedCollection[2], Is.EqualTo(new Vector3(7, 8, 9)));
        }
    }

    public class Array_FloatStringStruct_Test
    {
        public struct Message : NetworkMessage
        {
            public FloatStringStruct[] collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            FloatStringStruct[] unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            Message message = new Message
            {
                collection = new FloatStringStruct[] { }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            FloatStringStruct[] unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsEmpty(unpackedCollection);
        }

        [Test]
        public void SendsData()
        {
            Message message = new Message
            {
                collection = new FloatStringStruct[]
                {
                    new FloatStringStruct { value = 3, anotherValue = "Some" }, new FloatStringStruct { value = 4, anotherValue = "String" }, new FloatStringStruct { value = 5, anotherValue = "Values" }
                }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            FloatStringStruct[] unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsNotEmpty(unpackedCollection);
            Assert.That(unpackedCollection[0], Is.EqualTo(new FloatStringStruct { value = 3, anotherValue = "Some" }));
            Assert.That(unpackedCollection[1], Is.EqualTo(new FloatStringStruct { value = 4, anotherValue = "String" }));
            Assert.That(unpackedCollection[2], Is.EqualTo(new FloatStringStruct { value = 5, anotherValue = "Values" }));
        }
    }

    public class Array_ClassWithNoConstructor_Test
    {
        public struct Message : NetworkMessage
        {
            public ClassWithNoConstructor[] collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ClassWithNoConstructor[] unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            Message message = new Message
            {
                collection = new ClassWithNoConstructor[] { }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ClassWithNoConstructor[] unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsEmpty(unpackedCollection);
        }

        [Test]
        public void SendsData()
        {
            Message message = new Message
            {
                collection = new ClassWithNoConstructor[]
                {
                    new ClassWithNoConstructor { a = 3 }, new ClassWithNoConstructor { a = 4 }, new ClassWithNoConstructor { a = 5 }
                }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ClassWithNoConstructor[] unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsNotEmpty(unpackedCollection);
            Assert.That(unpackedCollection[0].a, Is.EqualTo(new ClassWithNoConstructor { a = 3 }.a));
            Assert.That(unpackedCollection[1].a, Is.EqualTo(new ClassWithNoConstructor { a = 4 }.a));
            Assert.That(unpackedCollection[2].a, Is.EqualTo(new ClassWithNoConstructor { a = 5 }.a));
        }
    }

    public class ArraySegment_int_Test
    {
        public struct Message : NetworkMessage
        {
            public ArraySegment<int> collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<int> unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection.Array, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            int[] array = new int[]
            {
                default,
                default,
                default,
            };

            Message message = new Message
            {
                collection = new ArraySegment<int>(array, 0, 0)
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<int> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection.Array);
            Assert.IsEmpty(unpackedCollection.Array);
        }

        [Test]
        public void SendsData()
        {
            int[] array = new int[]
            {
                default,
                3, 4, 5,
                default,
                default,
                default,
            };


            Message message = new Message
            {
                collection = new ArraySegment<int>(array, 1, 3)
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<int> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection.Array);
            Assert.IsNotEmpty(unpackedCollection.Array);
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 0], Is.EqualTo(3));
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 1], Is.EqualTo(4));
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 2], Is.EqualTo(5));
        }
    }

    public class ArraySegment_string_Test
    {
        public struct Message : NetworkMessage
        {
            public ArraySegment<string> collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<string> unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection.Array, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            string[] array = new string[]
            {
                default,
                default,
                default,
            };

            Message message = new Message
            {
                collection = new ArraySegment<string>(array, 0, 0)
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<string> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection.Array);
            Assert.IsEmpty(unpackedCollection.Array);
        }

        [Test]
        public void SendsData()
        {
            string[] array = new string[]
            {
                default,
                "Some", "String", "Value",
                default,
                default,
                default,
            };


            Message message = new Message
            {
                collection = new ArraySegment<string>(array, 1, 3)
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<string> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection.Array);
            Assert.IsNotEmpty(unpackedCollection.Array);
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 0], Is.EqualTo("Some"));
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 1], Is.EqualTo("String"));
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 2], Is.EqualTo("Value"));
        }
    }

    public class ArraySegment_Vector3_Test
    {
        public struct Message : NetworkMessage
        {
            public ArraySegment<Vector3> collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<Vector3> unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection.Array, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            Vector3[] array = new Vector3[]
            {
                default,
                default,
                default,
            };

            Message message = new Message
            {
                collection = new ArraySegment<Vector3>(array, 0, 0)
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<Vector3> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection.Array);
            Assert.IsEmpty(unpackedCollection.Array);
        }

        [Test]
        public void SendsData()
        {
            Vector3[] array = new Vector3[]
            {
                default,
                new Vector3(1, 2, 3), new Vector3(4, 5, 6), new Vector3(7, 8, 9),
                default,
                default,
                default,
            };


            Message message = new Message
            {
                collection = new ArraySegment<Vector3>(array, 1, 3)
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<Vector3> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection.Array);
            Assert.IsNotEmpty(unpackedCollection.Array);
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 0], Is.EqualTo(new Vector3(1, 2, 3)));
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 1], Is.EqualTo(new Vector3(4, 5, 6)));
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 2], Is.EqualTo(new Vector3(7, 8, 9)));
        }
    }

    public class ArraySegment_FloatStringStruct_Test
    {
        public struct Message : NetworkMessage
        {
            public ArraySegment<FloatStringStruct> collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<FloatStringStruct> unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection.Array, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            FloatStringStruct[] array = new FloatStringStruct[]
            {
                default,
                default,
                default,
            };

            Message message = new Message
            {
                collection = new ArraySegment<FloatStringStruct>(array, 0, 0)
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<FloatStringStruct> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection.Array);
            Assert.IsEmpty(unpackedCollection.Array);
        }

        [Test]
        public void SendsData()
        {
            FloatStringStruct[] array = new FloatStringStruct[]
            {
                default,
                new FloatStringStruct { value = 3, anotherValue = "Some" }, new FloatStringStruct { value = 4, anotherValue = "String" }, new FloatStringStruct { value = 5, anotherValue = "Values" },
                default,
                default,
                default,
            };


            Message message = new Message
            {
                collection = new ArraySegment<FloatStringStruct>(array, 1, 3)
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<FloatStringStruct> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection.Array);
            Assert.IsNotEmpty(unpackedCollection.Array);
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 0], Is.EqualTo(new FloatStringStruct { value = 3, anotherValue = "Some" }));
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 1], Is.EqualTo(new FloatStringStruct { value = 4, anotherValue = "String" }));
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 2], Is.EqualTo(new FloatStringStruct { value = 5, anotherValue = "Values" }));
        }
    }

    public class ArraySegment_ClassWithNoConstructor_Test
    {
        public struct Message : NetworkMessage
        {
            public ArraySegment<ClassWithNoConstructor> collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<ClassWithNoConstructor> unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection.Array, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            ClassWithNoConstructor[] array = new ClassWithNoConstructor[]
            {
                default,
                default,
                default,
            };

            Message message = new Message
            {
                collection = new ArraySegment<ClassWithNoConstructor>(array, 0, 0)
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<ClassWithNoConstructor> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection.Array);
            Assert.IsEmpty(unpackedCollection.Array);
        }

        [Test]
        public void SendsData()
        {
            ClassWithNoConstructor[] array = new ClassWithNoConstructor[]
            {
                default,
                new ClassWithNoConstructor { a = 3 }, new ClassWithNoConstructor { a = 4 }, new ClassWithNoConstructor { a = 5 },
                default,
                default,
                default,
            };


            Message message = new Message
            {
                collection = new ArraySegment<ClassWithNoConstructor>(array, 1, 3)
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            ArraySegment<ClassWithNoConstructor> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection.Array);
            Assert.IsNotEmpty(unpackedCollection.Array);
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 0].a, Is.EqualTo(new ClassWithNoConstructor { a = 3 }.a));
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 1].a, Is.EqualTo(new ClassWithNoConstructor { a = 4 }.a));
            Assert.That(unpackedCollection.Array[unpackedCollection.Offset + 2].a, Is.EqualTo(new ClassWithNoConstructor { a = 5 }.a));
        }
    }

    public class List_int_Test
    {
        public struct Message : NetworkMessage
        {
            public List<int> collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<int> unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            Message message = new Message
            {
                collection = new List<int> { }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<int> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsEmpty(unpackedCollection);
        }

        [Test]
        public void SendsData()
        {
            Message message = new Message
            {
                collection = new List<int>
                {
                    3, 4, 5
                }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<int> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsNotEmpty(unpackedCollection);
            Assert.That(unpackedCollection[0], Is.EqualTo(3));
            Assert.That(unpackedCollection[1], Is.EqualTo(4));
            Assert.That(unpackedCollection[2], Is.EqualTo(5));
        }
    }

    public class List_string_Test
    {
        public struct Message : NetworkMessage
        {
            public List<string> collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<string> unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            Message message = new Message
            {
                collection = new List<string> { }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<string> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsEmpty(unpackedCollection);
        }

        [Test]
        public void SendsData()
        {
            Message message = new Message
            {
                collection = new List<string>
                {
                    "Some", "String", "Value"
                }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<string> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsNotEmpty(unpackedCollection);
            Assert.That(unpackedCollection[0], Is.EqualTo("Some"));
            Assert.That(unpackedCollection[1], Is.EqualTo("String"));
            Assert.That(unpackedCollection[2], Is.EqualTo("Value"));
        }
    }

    public class List_Vector3_Test
    {
        public struct Message : NetworkMessage
        {
            public List<Vector3> collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<Vector3> unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            Message message = new Message
            {
                collection = new List<Vector3> { }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<Vector3> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsEmpty(unpackedCollection);
        }

        [Test]
        public void SendsData()
        {
            Message message = new Message
            {
                collection = new List<Vector3>
                {
                    new Vector3(1, 2, 3), new Vector3(4, 5, 6), new Vector3(7, 8, 9)
                }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<Vector3> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsNotEmpty(unpackedCollection);
            Assert.That(unpackedCollection[0], Is.EqualTo(new Vector3(1, 2, 3)));
            Assert.That(unpackedCollection[1], Is.EqualTo(new Vector3(4, 5, 6)));
            Assert.That(unpackedCollection[2], Is.EqualTo(new Vector3(7, 8, 9)));
        }
    }

    public class List_FloatStringStruct_Test
    {
        public struct Message : NetworkMessage
        {
            public List<FloatStringStruct> collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<FloatStringStruct> unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            Message message = new Message
            {
                collection = new List<FloatStringStruct> { }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<FloatStringStruct> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsEmpty(unpackedCollection);
        }

        [Test]
        public void SendsData()
        {
            Message message = new Message
            {
                collection = new List<FloatStringStruct>
                {
                    new FloatStringStruct { value = 3, anotherValue = "Some" }, new FloatStringStruct { value = 4, anotherValue = "String" }, new FloatStringStruct { value = 5, anotherValue = "Values" }
                }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<FloatStringStruct> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsNotEmpty(unpackedCollection);
            Assert.That(unpackedCollection[0], Is.EqualTo(new FloatStringStruct { value = 3, anotherValue = "Some" }));
            Assert.That(unpackedCollection[1], Is.EqualTo(new FloatStringStruct { value = 4, anotherValue = "String" }));
            Assert.That(unpackedCollection[2], Is.EqualTo(new FloatStringStruct { value = 5, anotherValue = "Values" }));
        }
    }

    public class List_ClassWithNoConstructor_Test
    {
        public struct Message : NetworkMessage
        {
            public List<ClassWithNoConstructor> collection;
        }

        [Test]
        public void SendsNull()
        {
            Message message = new Message
            {
                collection = default
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<ClassWithNoConstructor> unpackedCollection = unpacked.collection;

            Assert.That(unpackedCollection, Is.Null.Or.Empty);
        }

        [Test]
        public void SendsEmpty()
        {
            Message message = new Message
            {
                collection = new List<ClassWithNoConstructor> { }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<ClassWithNoConstructor> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsEmpty(unpackedCollection);
        }

        [Test]
        public void SendsData()
        {
            Message message = new Message
            {
                collection = new List<ClassWithNoConstructor>
                {
                    new ClassWithNoConstructor { a = 3 }, new ClassWithNoConstructor { a = 4 }, new ClassWithNoConstructor { a = 5 }
                }
            };

            byte[] data = MessagePackerTest.PackToByteArray(message);

            Message unpacked = MessagePacker.Unpack<Message>(data);
            List<ClassWithNoConstructor> unpackedCollection = unpacked.collection;

            Assert.IsNotNull(unpackedCollection);
            Assert.IsNotEmpty(unpackedCollection);
            Assert.That(unpackedCollection[0].a, Is.EqualTo(new ClassWithNoConstructor { a = 3 }.a));
            Assert.That(unpackedCollection[1].a, Is.EqualTo(new ClassWithNoConstructor { a = 4 }.a));
            Assert.That(unpackedCollection[2].a, Is.EqualTo(new ClassWithNoConstructor { a = 5 }.a));
        }
    }
}

// Decompiled with JetBrains decompiler
// Type: ProjectM.CodeGeneration.StunDefaultValueAttribute
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CodeGeneration
{
  public class StunDefaultValueAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Value_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Private_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SByte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Decimal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int16_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_0;

    public unsafe Il2CppSystem.Object Value
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr_set_Value_Private_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 35476, RefRangeEnd = 35499, XrefRangeStart = 35476, XrefRangeEnd = 35499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunDefaultValueAttribute(Il2CppSystem.Object value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633614, XrefRangeEnd = 633619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunDefaultValueAttribute(bool value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633619, XrefRangeEnd = 633624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunDefaultValueAttribute(byte value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633624, XrefRangeEnd = 633629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunDefaultValueAttribute(sbyte value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_SByte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633629, XrefRangeEnd = 633634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunDefaultValueAttribute(char value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633634, XrefRangeEnd = 633639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunDefaultValueAttribute(Il2CppSystem.Decimal value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633639, XrefRangeEnd = 633644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunDefaultValueAttribute(double value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633644, XrefRangeEnd = 633649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunDefaultValueAttribute(float value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633649, XrefRangeEnd = 633654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunDefaultValueAttribute(int value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633654, XrefRangeEnd = 633659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunDefaultValueAttribute(uint value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633659, XrefRangeEnd = 633664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunDefaultValueAttribute(long value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633664, XrefRangeEnd = 633669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunDefaultValueAttribute(ulong value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633669, XrefRangeEnd = 633674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunDefaultValueAttribute(short value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 633674, XrefRangeEnd = 633679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunDefaultValueAttribute(ushort value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StunDefaultValueAttribute()
    {
      Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.CodeGeneration", nameof (StunDefaultValueAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr);
      StunDefaultValueAttribute.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, "<Value>k__BackingField");
      StunDefaultValueAttribute.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663328);
      StunDefaultValueAttribute.NativeMethodInfoPtr_set_Value_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663329);
      StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663330);
      StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663331);
      StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663332);
      StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663333);
      StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663334);
      StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663335);
      StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663336);
      StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663337);
      StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663338);
      StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663339);
      StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663340);
      StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663341);
      StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663342);
      StunDefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunDefaultValueAttribute>.NativeClassPtr, 100663343);
    }

    public StunDefaultValueAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Object _Value_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StunDefaultValueAttribute.NativeFieldInfoPtr__Value_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StunDefaultValueAttribute.NativeFieldInfoPtr__Value_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}

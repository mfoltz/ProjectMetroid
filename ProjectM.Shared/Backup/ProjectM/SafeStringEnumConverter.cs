// Decompiled with JetBrains decompiler
// Type: ProjectM.SafeStringEnumConverter
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class SafeStringEnumConverter : StringEnumConverter
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DefaultValue_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0;

    public unsafe Il2CppSystem.Object DefaultValue
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SafeStringEnumConverter.NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740900, XrefRangeEnd = 740902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SafeStringEnumConverter(Il2CppSystem.Object defaultValue)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SafeStringEnumConverter>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) defaultValue);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SafeStringEnumConverter.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740902, XrefRangeEnd = 740904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppSystem.Object ReadJson(
      JsonReader reader,
      Il2CppSystem.Type objectType,
      Il2CppSystem.Object existingValue,
      JsonSerializer serializer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reader);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) objectType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) existingValue);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serializer);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SafeStringEnumConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    static SafeStringEnumConverter()
    {
      Il2CppClassPointerStore<SafeStringEnumConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SafeStringEnumConverter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SafeStringEnumConverter>.NativeClassPtr);
      SafeStringEnumConverter.NativeFieldInfoPtr__DefaultValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SafeStringEnumConverter>.NativeClassPtr, "<DefaultValue>k__BackingField");
      SafeStringEnumConverter.NativeMethodInfoPtr_get_DefaultValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringEnumConverter>.NativeClassPtr, 100665408);
      SafeStringEnumConverter.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringEnumConverter>.NativeClassPtr, 100665409);
      SafeStringEnumConverter.NativeMethodInfoPtr_ReadJson_Public_Virtual_Object_JsonReader_Type_Object_JsonSerializer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SafeStringEnumConverter>.NativeClassPtr, 100665410);
    }

    public SafeStringEnumConverter(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Object _DefaultValue_k__BackingField
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SafeStringEnumConverter.NativeFieldInfoPtr__DefaultValue_k__BackingField));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SafeStringEnumConverter.NativeFieldInfoPtr__DefaultValue_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}

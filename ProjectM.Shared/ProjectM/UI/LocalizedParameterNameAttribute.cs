// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LocalizedParameterNameAttribute
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  public class LocalizedParameterNameAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_NameIsField;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794794, XrefRangeEnd = 794796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizedParameterNameAttribute(string name, bool nameIsField)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedParameterNameAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nameIsField;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalizedParameterNameAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LocalizedParameterNameAttribute()
    {
      Il2CppClassPointerStore<LocalizedParameterNameAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (LocalizedParameterNameAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedParameterNameAttribute>.NativeClassPtr);
      LocalizedParameterNameAttribute.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedParameterNameAttribute>.NativeClassPtr, nameof (Name));
      LocalizedParameterNameAttribute.NativeFieldInfoPtr_NameIsField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedParameterNameAttribute>.NativeClassPtr, nameof (NameIsField));
      LocalizedParameterNameAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedParameterNameAttribute>.NativeClassPtr, 100670077);
    }

    public LocalizedParameterNameAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedParameterNameAttribute.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizedParameterNameAttribute.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool NameIsField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedParameterNameAttribute.NativeFieldInfoPtr_NameIsField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedParameterNameAttribute.NativeFieldInfoPtr_NameIsField)) = value;
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ProjectM.BindableSettingAttribute
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class BindableSettingAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FieldId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 35476, RefRangeEnd = 35499, XrefRangeStart = 35476, XrefRangeEnd = 35499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BindableSettingAttribute(string fieldId)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindableSettingAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(fieldId);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BindableSettingAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BindableSettingAttribute()
    {
      Il2CppClassPointerStore<BindableSettingAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BindableSettingAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindableSettingAttribute>.NativeClassPtr);
      BindableSettingAttribute.NativeFieldInfoPtr_FieldId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BindableSettingAttribute>.NativeClassPtr, nameof (FieldId));
      BindableSettingAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindableSettingAttribute>.NativeClassPtr, 100667480);
    }

    public BindableSettingAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string FieldId
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BindableSettingAttribute.NativeFieldInfoPtr_FieldId)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BindableSettingAttribute.NativeFieldInfoPtr_FieldId), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}

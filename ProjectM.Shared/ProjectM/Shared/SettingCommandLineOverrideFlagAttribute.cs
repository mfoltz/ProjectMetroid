// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SettingCommandLineOverrideFlagAttribute
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  public class SettingCommandLineOverrideFlagAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ParameterEnable;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParameterDisable;
    private static readonly System.IntPtr NativeFieldInfoPtr__Invert;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParameterEnable_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParameterDisable_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Invert_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasEnable_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasDisable_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0;

    public unsafe string ParameterEnable
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SettingCommandLineOverrideFlagAttribute.NativeMethodInfoPtr_get_ParameterEnable_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string ParameterDisable
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SettingCommandLineOverrideFlagAttribute.NativeMethodInfoPtr_get_ParameterDisable_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe bool Invert
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingCommandLineOverrideFlagAttribute.NativeMethodInfoPtr_get_Invert_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool HasEnable
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802213, XrefRangeEnd = 802214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingCommandLineOverrideFlagAttribute.NativeMethodInfoPtr_get_HasEnable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool HasDisable
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802214, XrefRangeEnd = 802215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingCommandLineOverrideFlagAttribute.NativeMethodInfoPtr_get_HasDisable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 35012, RefRangeEnd = 35015, XrefRangeStart = 35012, XrefRangeEnd = 35015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SettingCommandLineOverrideFlagAttribute(
      string paramEnable = null,
      string paramDisable = null,
      bool invert = false)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingCommandLineOverrideFlagAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(paramEnable);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(paramDisable);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &invert;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingCommandLineOverrideFlagAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SettingCommandLineOverrideFlagAttribute()
    {
      Il2CppClassPointerStore<SettingCommandLineOverrideFlagAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SettingCommandLineOverrideFlagAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingCommandLineOverrideFlagAttribute>.NativeClassPtr);
      SettingCommandLineOverrideFlagAttribute.NativeFieldInfoPtr__ParameterEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCommandLineOverrideFlagAttribute>.NativeClassPtr, nameof (_ParameterEnable));
      SettingCommandLineOverrideFlagAttribute.NativeFieldInfoPtr__ParameterDisable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCommandLineOverrideFlagAttribute>.NativeClassPtr, nameof (_ParameterDisable));
      SettingCommandLineOverrideFlagAttribute.NativeFieldInfoPtr__Invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCommandLineOverrideFlagAttribute>.NativeClassPtr, nameof (_Invert));
      SettingCommandLineOverrideFlagAttribute.NativeMethodInfoPtr_get_ParameterEnable_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCommandLineOverrideFlagAttribute>.NativeClassPtr, 100670749);
      SettingCommandLineOverrideFlagAttribute.NativeMethodInfoPtr_get_ParameterDisable_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCommandLineOverrideFlagAttribute>.NativeClassPtr, 100670750);
      SettingCommandLineOverrideFlagAttribute.NativeMethodInfoPtr_get_Invert_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCommandLineOverrideFlagAttribute>.NativeClassPtr, 100670751);
      SettingCommandLineOverrideFlagAttribute.NativeMethodInfoPtr_get_HasEnable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCommandLineOverrideFlagAttribute>.NativeClassPtr, 100670752);
      SettingCommandLineOverrideFlagAttribute.NativeMethodInfoPtr_get_HasDisable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCommandLineOverrideFlagAttribute>.NativeClassPtr, 100670753);
      SettingCommandLineOverrideFlagAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCommandLineOverrideFlagAttribute>.NativeClassPtr, 100670754);
    }

    public SettingCommandLineOverrideFlagAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _ParameterEnable
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingCommandLineOverrideFlagAttribute.NativeFieldInfoPtr__ParameterEnable)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SettingCommandLineOverrideFlagAttribute.NativeFieldInfoPtr__ParameterEnable), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _ParameterDisable
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingCommandLineOverrideFlagAttribute.NativeFieldInfoPtr__ParameterDisable)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SettingCommandLineOverrideFlagAttribute.NativeFieldInfoPtr__ParameterDisable), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool _Invert
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingCommandLineOverrideFlagAttribute.NativeFieldInfoPtr__Invert));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingCommandLineOverrideFlagAttribute.NativeFieldInfoPtr__Invert)) = value;
      }
    }
  }
}

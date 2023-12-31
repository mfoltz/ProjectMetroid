// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SettingCommandLineOverrideAttribute
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
  public class SettingCommandLineOverrideAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Paramater;
    private static readonly System.IntPtr NativeFieldInfoPtr__deprecationMessage;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParseNewLines;
    private static readonly System.IntPtr NativeFieldInfoPtr__Invert;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Parameter_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DeprecationMessage_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Deprecated_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParseNewLines_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Invert_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_Boolean_0;

    public unsafe string Parameter
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SettingCommandLineOverrideAttribute.NativeMethodInfoPtr_get_Parameter_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string DeprecationMessage
    {
      [CallerCount(9), CachedScanResults(RefRangeStart = 16432, RefRangeEnd = 16441, XrefRangeStart = 16432, XrefRangeEnd = 16441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SettingCommandLineOverrideAttribute.NativeMethodInfoPtr_get_DeprecationMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe bool Deprecated
    {
      [CallerCount(45), CachedScanResults(RefRangeStart = 363553, RefRangeEnd = 363598, XrefRangeStart = 363553, XrefRangeEnd = 363598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingCommandLineOverrideAttribute.NativeMethodInfoPtr_get_Deprecated_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool ParseNewLines
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingCommandLineOverrideAttribute.NativeMethodInfoPtr_get_ParseNewLines_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool Invert
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SettingCommandLineOverrideAttribute.NativeMethodInfoPtr_get_Invert_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 802210, XrefRangeEnd = 802213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SettingCommandLineOverrideAttribute(
      string parameter,
      string deprecationMessage = null,
      bool parseNewLines = false,
      bool invert = false)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingCommandLineOverrideAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(parameter);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(deprecationMessage);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &parseNewLines;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &invert;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SettingCommandLineOverrideAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SettingCommandLineOverrideAttribute()
    {
      Il2CppClassPointerStore<SettingCommandLineOverrideAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SettingCommandLineOverrideAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingCommandLineOverrideAttribute>.NativeClassPtr);
      SettingCommandLineOverrideAttribute.NativeFieldInfoPtr__Paramater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCommandLineOverrideAttribute>.NativeClassPtr, nameof (_Paramater));
      SettingCommandLineOverrideAttribute.NativeFieldInfoPtr__deprecationMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCommandLineOverrideAttribute>.NativeClassPtr, nameof (_deprecationMessage));
      SettingCommandLineOverrideAttribute.NativeFieldInfoPtr__ParseNewLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCommandLineOverrideAttribute>.NativeClassPtr, nameof (_ParseNewLines));
      SettingCommandLineOverrideAttribute.NativeFieldInfoPtr__Invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingCommandLineOverrideAttribute>.NativeClassPtr, nameof (_Invert));
      SettingCommandLineOverrideAttribute.NativeMethodInfoPtr_get_Parameter_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCommandLineOverrideAttribute>.NativeClassPtr, 100670743);
      SettingCommandLineOverrideAttribute.NativeMethodInfoPtr_get_DeprecationMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCommandLineOverrideAttribute>.NativeClassPtr, 100670744);
      SettingCommandLineOverrideAttribute.NativeMethodInfoPtr_get_Deprecated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCommandLineOverrideAttribute>.NativeClassPtr, 100670745);
      SettingCommandLineOverrideAttribute.NativeMethodInfoPtr_get_ParseNewLines_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCommandLineOverrideAttribute>.NativeClassPtr, 100670746);
      SettingCommandLineOverrideAttribute.NativeMethodInfoPtr_get_Invert_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCommandLineOverrideAttribute>.NativeClassPtr, 100670747);
      SettingCommandLineOverrideAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingCommandLineOverrideAttribute>.NativeClassPtr, 100670748);
    }

    public SettingCommandLineOverrideAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _Paramater
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingCommandLineOverrideAttribute.NativeFieldInfoPtr__Paramater)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SettingCommandLineOverrideAttribute.NativeFieldInfoPtr__Paramater), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _deprecationMessage
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingCommandLineOverrideAttribute.NativeFieldInfoPtr__deprecationMessage)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SettingCommandLineOverrideAttribute.NativeFieldInfoPtr__deprecationMessage), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool _ParseNewLines
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingCommandLineOverrideAttribute.NativeFieldInfoPtr__ParseNewLines));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingCommandLineOverrideAttribute.NativeFieldInfoPtr__ParseNewLines)) = value;
      }
    }

    public unsafe bool _Invert
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingCommandLineOverrideAttribute.NativeFieldInfoPtr__Invert));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SettingCommandLineOverrideAttribute.NativeFieldInfoPtr__Invert)) = value;
      }
    }
  }
}

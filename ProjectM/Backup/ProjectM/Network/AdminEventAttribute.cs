// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.AdminEventAttribute
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  public class AdminEventAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRequiredLevel;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRequiredAuthMethod;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseSharedSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr_NotifyUsers;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1145420, XrefRangeEnd = 1145421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AdminEventAttribute()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdminEventAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AdminEventAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AdminEventAttribute()
    {
      Il2CppClassPointerStore<AdminEventAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (AdminEventAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdminEventAttribute>.NativeClassPtr);
      AdminEventAttribute.NativeFieldInfoPtr_MinRequiredLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminEventAttribute>.NativeClassPtr, nameof (MinRequiredLevel));
      AdminEventAttribute.NativeFieldInfoPtr_MinRequiredAuthMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminEventAttribute>.NativeClassPtr, nameof (MinRequiredAuthMethod));
      AdminEventAttribute.NativeFieldInfoPtr_UseSharedSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminEventAttribute>.NativeClassPtr, nameof (UseSharedSystem));
      AdminEventAttribute.NativeFieldInfoPtr_NotifyUsers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdminEventAttribute>.NativeClassPtr, nameof (NotifyUsers));
      AdminEventAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdminEventAttribute>.NativeClassPtr, 100690762);
    }

    public AdminEventAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AdminLevel MinRequiredLevel
    {
      get
      {
        return *(AdminLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdminEventAttribute.NativeFieldInfoPtr_MinRequiredLevel));
      }
      [param: In] set
      {
        *(AdminLevel*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdminEventAttribute.NativeFieldInfoPtr_MinRequiredLevel)) = value;
      }
    }

    public unsafe AdminAuthMethod MinRequiredAuthMethod
    {
      get
      {
        return *(AdminAuthMethod*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdminEventAttribute.NativeFieldInfoPtr_MinRequiredAuthMethod));
      }
      [param: In] set
      {
        *(AdminAuthMethod*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdminEventAttribute.NativeFieldInfoPtr_MinRequiredAuthMethod)) = value;
      }
    }

    public unsafe bool UseSharedSystem
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdminEventAttribute.NativeFieldInfoPtr_UseSharedSystem));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdminEventAttribute.NativeFieldInfoPtr_UseSharedSystem)) = value;
      }
    }

    public unsafe bool NotifyUsers
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdminEventAttribute.NativeFieldInfoPtr_NotifyUsers));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AdminEventAttribute.NativeFieldInfoPtr_NotifyUsers)) = value;
      }
    }
  }
}

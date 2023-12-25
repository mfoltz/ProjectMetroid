// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerUseWeaponOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  public sealed class LogPlayerUseWeaponOptions : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__UseWeaponData_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UseWeaponData_Public_get_Nullable_1_LogPlayerUseWeaponData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UseWeaponData_Public_set_Void_Nullable_1_LogPlayerUseWeaponData_0;

    public unsafe Il2CppSystem.Nullable<LogPlayerUseWeaponData> UseWeaponData
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 587685, RefRangeEnd = 587689, XrefRangeStart = 587685, XrefRangeEnd = 587689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponOptions.NativeMethodInfoPtr_get_UseWeaponData_Public_get_Nullable_1_LogPlayerUseWeaponData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<LogPlayerUseWeaponData>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970486, XrefRangeEnd = 970487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerUseWeaponOptions.NativeMethodInfoPtr_set_UseWeaponData_Public_set_Void_Nullable_1_LogPlayerUseWeaponData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static LogPlayerUseWeaponOptions()
    {
      Il2CppClassPointerStore<LogPlayerUseWeaponOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerUseWeaponOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerUseWeaponOptions>.NativeClassPtr);
      LogPlayerUseWeaponOptions.NativeFieldInfoPtr__UseWeaponData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseWeaponOptions>.NativeClassPtr, "<UseWeaponData>k__BackingField");
      LogPlayerUseWeaponOptions.NativeMethodInfoPtr_get_UseWeaponData_Public_get_Nullable_1_LogPlayerUseWeaponData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponOptions>.NativeClassPtr, 100674165);
      LogPlayerUseWeaponOptions.NativeMethodInfoPtr_set_UseWeaponData_Public_set_Void_Nullable_1_LogPlayerUseWeaponData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseWeaponOptions>.NativeClassPtr, 100674166);
    }

    public LogPlayerUseWeaponOptions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public LogPlayerUseWeaponOptions()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LogPlayerUseWeaponOptions>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerUseWeaponOptions>.NativeClassPtr, data));
    }

    public Il2CppSystem.Nullable<LogPlayerUseWeaponData> _UseWeaponData_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerUseWeaponOptions.NativeFieldInfoPtr__UseWeaponData_k__BackingField);
        return new Il2CppSystem.Nullable<LogPlayerUseWeaponData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<LogPlayerUseWeaponData>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerUseWeaponOptions.NativeFieldInfoPtr__UseWeaponData_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<LogPlayerUseWeaponData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerUseAbilityOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LogPlayerUseAbilityOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PlayerHandle_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityDurationMs_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__AbilityCooldownMs_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AbilityId_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AbilityId_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AbilityDurationMs_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AbilityDurationMs_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AbilityCooldownMs_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AbilityCooldownMs_Public_set_Void_UInt32_0;
    [FieldOffset(0)]
    public System.IntPtr _PlayerHandle_k__BackingField;
    [FieldOffset(8)]
    public uint _AbilityId_k__BackingField;
    [FieldOffset(12)]
    public uint _AbilityDurationMs_k__BackingField;
    [FieldOffset(16)]
    public uint _AbilityCooldownMs_k__BackingField;

    public unsafe System.IntPtr PlayerHandle
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptions.NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptions.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint AbilityId
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptions.NativeMethodInfoPtr_get_AbilityId_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(11), CachedScanResults(RefRangeStart = 204781, RefRangeEnd = 204792, XrefRangeStart = 204781, XrefRangeEnd = 204792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptions.NativeMethodInfoPtr_set_AbilityId_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint AbilityDurationMs
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptions.NativeMethodInfoPtr_get_AbilityDurationMs_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(9), CachedScanResults(RefRangeStart = 204792, RefRangeEnd = 204801, XrefRangeStart = 204792, XrefRangeEnd = 204801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptions.NativeMethodInfoPtr_set_AbilityDurationMs_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint AbilityCooldownMs
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptions.NativeMethodInfoPtr_get_AbilityCooldownMs_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerUseAbilityOptions.NativeMethodInfoPtr_set_AbilityCooldownMs_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static LogPlayerUseAbilityOptions()
    {
      Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerUseAbilityOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr);
      LogPlayerUseAbilityOptions.NativeFieldInfoPtr__PlayerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr, "<PlayerHandle>k__BackingField");
      LogPlayerUseAbilityOptions.NativeFieldInfoPtr__AbilityId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr, "<AbilityId>k__BackingField");
      LogPlayerUseAbilityOptions.NativeFieldInfoPtr__AbilityDurationMs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr, "<AbilityDurationMs>k__BackingField");
      LogPlayerUseAbilityOptions.NativeFieldInfoPtr__AbilityCooldownMs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr, "<AbilityCooldownMs>k__BackingField");
      LogPlayerUseAbilityOptions.NativeMethodInfoPtr_get_PlayerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr, 100674121);
      LogPlayerUseAbilityOptions.NativeMethodInfoPtr_set_PlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr, 100674122);
      LogPlayerUseAbilityOptions.NativeMethodInfoPtr_get_AbilityId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr, 100674123);
      LogPlayerUseAbilityOptions.NativeMethodInfoPtr_set_AbilityId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr, 100674124);
      LogPlayerUseAbilityOptions.NativeMethodInfoPtr_get_AbilityDurationMs_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr, 100674125);
      LogPlayerUseAbilityOptions.NativeMethodInfoPtr_set_AbilityDurationMs_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr, 100674126);
      LogPlayerUseAbilityOptions.NativeMethodInfoPtr_get_AbilityCooldownMs_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr, 100674127);
      LogPlayerUseAbilityOptions.NativeMethodInfoPtr_set_AbilityCooldownMs_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr, 100674128);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerUseAbilityOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

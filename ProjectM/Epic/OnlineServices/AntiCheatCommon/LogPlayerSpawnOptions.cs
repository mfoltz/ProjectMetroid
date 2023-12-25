// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerSpawnOptions
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
  public struct LogPlayerSpawnOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnedPlayerHandle_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__TeamId_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__CharacterId_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SpawnedPlayerHandle_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SpawnedPlayerHandle_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TeamId_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_TeamId_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CharacterId_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_CharacterId_Public_set_Void_UInt32_0;
    [FieldOffset(0)]
    public System.IntPtr _SpawnedPlayerHandle_k__BackingField;
    [FieldOffset(8)]
    public uint _TeamId_k__BackingField;
    [FieldOffset(12)]
    public uint _CharacterId_k__BackingField;

    public unsafe System.IntPtr SpawnedPlayerHandle
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptions.NativeMethodInfoPtr_get_SpawnedPlayerHandle_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptions.NativeMethodInfoPtr_set_SpawnedPlayerHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint TeamId
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptions.NativeMethodInfoPtr_get_TeamId_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(11), CachedScanResults(RefRangeStart = 204781, RefRangeEnd = 204792, XrefRangeStart = 204781, XrefRangeEnd = 204792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptions.NativeMethodInfoPtr_set_TeamId_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint CharacterId
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptions.NativeMethodInfoPtr_get_CharacterId_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(9), CachedScanResults(RefRangeStart = 204792, RefRangeEnd = 204801, XrefRangeStart = 204792, XrefRangeEnd = 204801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptions.NativeMethodInfoPtr_set_CharacterId_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static LogPlayerSpawnOptions()
    {
      Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerSpawnOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr);
      LogPlayerSpawnOptions.NativeFieldInfoPtr__SpawnedPlayerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, "<SpawnedPlayerHandle>k__BackingField");
      LogPlayerSpawnOptions.NativeFieldInfoPtr__TeamId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, "<TeamId>k__BackingField");
      LogPlayerSpawnOptions.NativeFieldInfoPtr__CharacterId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, "<CharacterId>k__BackingField");
      LogPlayerSpawnOptions.NativeMethodInfoPtr_get_SpawnedPlayerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, 100674031);
      LogPlayerSpawnOptions.NativeMethodInfoPtr_set_SpawnedPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, 100674032);
      LogPlayerSpawnOptions.NativeMethodInfoPtr_get_TeamId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, 100674033);
      LogPlayerSpawnOptions.NativeMethodInfoPtr_set_TeamId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, 100674034);
      LogPlayerSpawnOptions.NativeMethodInfoPtr_get_CharacterId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, 100674035);
      LogPlayerSpawnOptions.NativeMethodInfoPtr_set_CharacterId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, 100674036);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

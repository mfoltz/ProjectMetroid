// Decompiled with JetBrains decompiler
// Type: ProjectM.PlayerLevelDamageSettings
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct PlayerLevelDamageSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LevelDiff;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageModifier;
    private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_PlayerLevelDamageSettings_PlayerLevelDamageSettings_PlayerLevelDamageSettings_Single_0;
    [FieldOffset(0)]
    public float LevelDiff;
    [FieldOffset(4)]
    public float DamageModifier;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1067498, RefRangeEnd = 1067499, XrefRangeStart = 1067498, XrefRangeEnd = 1067498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PlayerLevelDamageSettings Lerp(
      PlayerLevelDamageSettings from,
      PlayerLevelDamageSettings to,
      float s)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &from;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &to;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &s;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PlayerLevelDamageSettings.NativeMethodInfoPtr_Lerp_Public_Static_PlayerLevelDamageSettings_PlayerLevelDamageSettings_PlayerLevelDamageSettings_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PlayerLevelDamageSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PlayerLevelDamageSettings()
    {
      Il2CppClassPointerStore<PlayerLevelDamageSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PlayerLevelDamageSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLevelDamageSettings>.NativeClassPtr);
      PlayerLevelDamageSettings.NativeFieldInfoPtr_LevelDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLevelDamageSettings>.NativeClassPtr, nameof (LevelDiff));
      PlayerLevelDamageSettings.NativeFieldInfoPtr_DamageModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLevelDamageSettings>.NativeClassPtr, nameof (DamageModifier));
      PlayerLevelDamageSettings.NativeMethodInfoPtr_Lerp_Public_Static_PlayerLevelDamageSettings_PlayerLevelDamageSettings_PlayerLevelDamageSettings_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLevelDamageSettings>.NativeClassPtr, 100683974);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerLevelDamageSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

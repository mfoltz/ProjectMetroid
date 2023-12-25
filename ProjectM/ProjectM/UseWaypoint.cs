// Decompiled with JetBrains decompiler
// Type: ProjectM.UseWaypoint
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UseWaypoint
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ToFewPortalUnlocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_TeleportBoundItemText;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasCharmedUnitText;
    private static readonly System.IntPtr NativeFieldInfoPtr_TeleportBoundItemSctTypeGuid;
    [FieldOffset(0)]
    public LocalizationKey ToFewPortalUnlocked;
    [FieldOffset(16)]
    public LocalizationKey TeleportBoundItemText;
    [FieldOffset(32)]
    public LocalizationKey HasCharmedUnitText;
    [FieldOffset(48)]
    public PrefabGUID TeleportBoundItemSctTypeGuid;

    static UseWaypoint()
    {
      Il2CppClassPointerStore<UseWaypoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UseWaypoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseWaypoint>.NativeClassPtr);
      UseWaypoint.NativeFieldInfoPtr_ToFewPortalUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseWaypoint>.NativeClassPtr, nameof (ToFewPortalUnlocked));
      UseWaypoint.NativeFieldInfoPtr_TeleportBoundItemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseWaypoint>.NativeClassPtr, nameof (TeleportBoundItemText));
      UseWaypoint.NativeFieldInfoPtr_HasCharmedUnitText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseWaypoint>.NativeClassPtr, nameof (HasCharmedUnitText));
      UseWaypoint.NativeFieldInfoPtr_TeleportBoundItemSctTypeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseWaypoint>.NativeClassPtr, nameof (TeleportBoundItemSctTypeGuid));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UseWaypoint>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

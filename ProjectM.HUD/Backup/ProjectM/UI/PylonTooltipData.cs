// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.PylonTooltipData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PylonTooltipData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PylonBounds;
    private static readonly System.IntPtr NativeFieldInfoPtr_PylonTeam;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsAlly;
    private static readonly System.IntPtr NativeFieldInfoPtr_OwnerName;
    [FieldOffset(0)]
    public Bounds PylonBounds;
    [FieldOffset(24)]
    public Team PylonTeam;
    [FieldOffset(32)]
    public bool IsAlly;
    [FieldOffset(34)]
    public FixedString64 OwnerName;

    static PylonTooltipData()
    {
      Il2CppClassPointerStore<PylonTooltipData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (PylonTooltipData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PylonTooltipData>.NativeClassPtr);
      PylonTooltipData.NativeFieldInfoPtr_PylonBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonTooltipData>.NativeClassPtr, nameof (PylonBounds));
      PylonTooltipData.NativeFieldInfoPtr_PylonTeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonTooltipData>.NativeClassPtr, nameof (PylonTeam));
      PylonTooltipData.NativeFieldInfoPtr_IsAlly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonTooltipData>.NativeClassPtr, nameof (IsAlly));
      PylonTooltipData.NativeFieldInfoPtr_OwnerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PylonTooltipData>.NativeClassPtr, nameof (OwnerName));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PylonTooltipData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

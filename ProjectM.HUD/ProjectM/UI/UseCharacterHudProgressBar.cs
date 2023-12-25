// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.UseCharacterHudProgressBar
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UseCharacterHudProgressBar
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_GuidHash;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxProgress;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowOn;
    [FieldOffset(0)]
    public Entity Target;
    [FieldOffset(8)]
    public Entity BuffOwner;
    [FieldOffset(16)]
    public int GuidHash;
    [FieldOffset(20)]
    public int Importance;
    [FieldOffset(24)]
    public float Progress;
    [FieldOffset(28)]
    public float MaxProgress;
    [FieldOffset(32)]
    public HudShowFilter ShowFilter;
    [FieldOffset(36)]
    public HudShowOn ShowOn;

    static UseCharacterHudProgressBar()
    {
      Il2CppClassPointerStore<UseCharacterHudProgressBar>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (UseCharacterHudProgressBar));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseCharacterHudProgressBar>.NativeClassPtr);
      UseCharacterHudProgressBar.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseCharacterHudProgressBar>.NativeClassPtr, nameof (Target));
      UseCharacterHudProgressBar.NativeFieldInfoPtr_BuffOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseCharacterHudProgressBar>.NativeClassPtr, nameof (BuffOwner));
      UseCharacterHudProgressBar.NativeFieldInfoPtr_GuidHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseCharacterHudProgressBar>.NativeClassPtr, nameof (GuidHash));
      UseCharacterHudProgressBar.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseCharacterHudProgressBar>.NativeClassPtr, nameof (Importance));
      UseCharacterHudProgressBar.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseCharacterHudProgressBar>.NativeClassPtr, nameof (Progress));
      UseCharacterHudProgressBar.NativeFieldInfoPtr_MaxProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseCharacterHudProgressBar>.NativeClassPtr, nameof (MaxProgress));
      UseCharacterHudProgressBar.NativeFieldInfoPtr_ShowFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseCharacterHudProgressBar>.NativeClassPtr, nameof (ShowFilter));
      UseCharacterHudProgressBar.NativeFieldInfoPtr_ShowOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseCharacterHudProgressBar>.NativeClassPtr, nameof (ShowOn));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UseCharacterHudProgressBar>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

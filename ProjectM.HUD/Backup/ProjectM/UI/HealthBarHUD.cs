// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.HealthBarHUD
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct HealthBarHUD
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LastHealthChangeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthAnimationDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthAnimationTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_CalculatedHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_GoalHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastMaxHealth;
    private static readonly System.IntPtr NativeFieldInfoPtr_Absorb;
    private static readonly System.IntPtr NativeFieldInfoPtr_HUDIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastFrameUpdated;
    [FieldOffset(0)]
    public double LastHealthChangeTime;
    [FieldOffset(8)]
    public float HealthAnimationDelay;
    [FieldOffset(12)]
    public float HealthAnimationTime;
    [FieldOffset(16)]
    public float StartHealth;
    [FieldOffset(20)]
    public float CalculatedHealth;
    [FieldOffset(24)]
    public float GoalHealth;
    [FieldOffset(28)]
    public float FadeDistance;
    [FieldOffset(32)]
    public float LastMaxHealth;
    [FieldOffset(36)]
    public float Absorb;
    [FieldOffset(40)]
    public int HUDIndex;
    [FieldOffset(44)]
    public int LastFrameUpdated;

    static HealthBarHUD()
    {
      Il2CppClassPointerStore<HealthBarHUD>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (HealthBarHUD));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HealthBarHUD>.NativeClassPtr);
      HealthBarHUD.NativeFieldInfoPtr_LastHealthChangeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthBarHUD>.NativeClassPtr, nameof (LastHealthChangeTime));
      HealthBarHUD.NativeFieldInfoPtr_HealthAnimationDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthBarHUD>.NativeClassPtr, nameof (HealthAnimationDelay));
      HealthBarHUD.NativeFieldInfoPtr_HealthAnimationTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthBarHUD>.NativeClassPtr, nameof (HealthAnimationTime));
      HealthBarHUD.NativeFieldInfoPtr_StartHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthBarHUD>.NativeClassPtr, nameof (StartHealth));
      HealthBarHUD.NativeFieldInfoPtr_CalculatedHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthBarHUD>.NativeClassPtr, nameof (CalculatedHealth));
      HealthBarHUD.NativeFieldInfoPtr_GoalHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthBarHUD>.NativeClassPtr, nameof (GoalHealth));
      HealthBarHUD.NativeFieldInfoPtr_FadeDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthBarHUD>.NativeClassPtr, nameof (FadeDistance));
      HealthBarHUD.NativeFieldInfoPtr_LastMaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthBarHUD>.NativeClassPtr, nameof (LastMaxHealth));
      HealthBarHUD.NativeFieldInfoPtr_Absorb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthBarHUD>.NativeClassPtr, nameof (Absorb));
      HealthBarHUD.NativeFieldInfoPtr_HUDIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthBarHUD>.NativeClassPtr, nameof (HUDIndex));
      HealthBarHUD.NativeFieldInfoPtr_LastFrameUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HealthBarHUD>.NativeClassPtr, nameof (LastFrameUpdated));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HealthBarHUD>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

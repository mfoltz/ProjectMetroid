// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_ProjectileSpread_Channel_Data
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_ProjectileSpread_Channel_Data
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Angle;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Projectile;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_ProjectilesSpawned;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseCustomDuration;
    [FieldOffset(0)]
    public float Angle;
    [FieldOffset(4)]
    public float CustomDuration;
    [FieldOffset(8)]
    public PrefabGUID Projectile;
    [FieldOffset(12)]
    public int Count;
    [FieldOffset(16)]
    public int ProjectilesSpawned;
    [FieldOffset(20)]
    public CurveReference Curve;
    [FieldOffset(28)]
    public bool UseCustomDuration;

    static Script_ProjectileSpread_Channel_Data()
    {
      Il2CppClassPointerStore<Script_ProjectileSpread_Channel_Data>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_ProjectileSpread_Channel_Data));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_ProjectileSpread_Channel_Data>.NativeClassPtr);
      Script_ProjectileSpread_Channel_Data.NativeFieldInfoPtr_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProjectileSpread_Channel_Data>.NativeClassPtr, nameof (Angle));
      Script_ProjectileSpread_Channel_Data.NativeFieldInfoPtr_CustomDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProjectileSpread_Channel_Data>.NativeClassPtr, nameof (CustomDuration));
      Script_ProjectileSpread_Channel_Data.NativeFieldInfoPtr_Projectile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProjectileSpread_Channel_Data>.NativeClassPtr, nameof (Projectile));
      Script_ProjectileSpread_Channel_Data.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProjectileSpread_Channel_Data>.NativeClassPtr, nameof (Count));
      Script_ProjectileSpread_Channel_Data.NativeFieldInfoPtr_ProjectilesSpawned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProjectileSpread_Channel_Data>.NativeClassPtr, nameof (ProjectilesSpawned));
      Script_ProjectileSpread_Channel_Data.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProjectileSpread_Channel_Data>.NativeClassPtr, nameof (Curve));
      Script_ProjectileSpread_Channel_Data.NativeFieldInfoPtr_UseCustomDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_ProjectileSpread_Channel_Data>.NativeClassPtr, nameof (UseCustomDuration));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_ProjectileSpread_Channel_Data>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.AbilityProjectileFanOnGameplayEvent_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityProjectileFanOnGameplayEvent_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Angle;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_IndividualRandom;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewProjectileEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewProjectileEntityAlternate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_TickCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseOwnerAimDirection;
    [FieldOffset(0)]
    public float Angle;
    [FieldOffset(4)]
    public float OffsetAngle;
    [FieldOffset(8)]
    public float RandomOffset;
    [FieldOffset(12)]
    public float IndividualRandom;
    [FieldOffset(16)]
    public PrefabGUID NewProjectileEntity;
    [FieldOffset(20)]
    public PrefabGUID NewProjectileEntityAlternate;
    [FieldOffset(24)]
    public int Count;
    [FieldOffset(28)]
    public int TickCount;
    [FieldOffset(32)]
    public bool UseOwnerAimDirection;

    static AbilityProjectileFanOnGameplayEvent_DataServer()
    {
      Il2CppClassPointerStore<AbilityProjectileFanOnGameplayEvent_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (AbilityProjectileFanOnGameplayEvent_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityProjectileFanOnGameplayEvent_DataServer>.NativeClassPtr);
      AbilityProjectileFanOnGameplayEvent_DataServer.NativeFieldInfoPtr_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityProjectileFanOnGameplayEvent_DataServer>.NativeClassPtr, nameof (Angle));
      AbilityProjectileFanOnGameplayEvent_DataServer.NativeFieldInfoPtr_OffsetAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityProjectileFanOnGameplayEvent_DataServer>.NativeClassPtr, nameof (OffsetAngle));
      AbilityProjectileFanOnGameplayEvent_DataServer.NativeFieldInfoPtr_RandomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityProjectileFanOnGameplayEvent_DataServer>.NativeClassPtr, nameof (RandomOffset));
      AbilityProjectileFanOnGameplayEvent_DataServer.NativeFieldInfoPtr_IndividualRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityProjectileFanOnGameplayEvent_DataServer>.NativeClassPtr, nameof (IndividualRandom));
      AbilityProjectileFanOnGameplayEvent_DataServer.NativeFieldInfoPtr_NewProjectileEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityProjectileFanOnGameplayEvent_DataServer>.NativeClassPtr, nameof (NewProjectileEntity));
      AbilityProjectileFanOnGameplayEvent_DataServer.NativeFieldInfoPtr_NewProjectileEntityAlternate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityProjectileFanOnGameplayEvent_DataServer>.NativeClassPtr, nameof (NewProjectileEntityAlternate));
      AbilityProjectileFanOnGameplayEvent_DataServer.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityProjectileFanOnGameplayEvent_DataServer>.NativeClassPtr, nameof (Count));
      AbilityProjectileFanOnGameplayEvent_DataServer.NativeFieldInfoPtr_TickCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityProjectileFanOnGameplayEvent_DataServer>.NativeClassPtr, nameof (TickCount));
      AbilityProjectileFanOnGameplayEvent_DataServer.NativeFieldInfoPtr_UseOwnerAimDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityProjectileFanOnGameplayEvent_DataServer>.NativeClassPtr, nameof (UseOwnerAimDirection));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityProjectileFanOnGameplayEvent_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

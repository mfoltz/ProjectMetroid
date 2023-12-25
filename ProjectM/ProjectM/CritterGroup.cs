// Decompiled with JetBrains decompiler
// Type: ProjectM.CritterGroup
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Fmod;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CritterGroup
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FleeSoundGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinMaxCritters;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResetZoneRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActivationZoneRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_EscapeZoneRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnZoneRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxAliveTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentAliveTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_BaseCritterGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumCritters;
    private static readonly System.IntPtr NativeFieldInfoPtr_InnerActiveSphere;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsTemporary;
    private static readonly System.IntPtr NativeFieldInfoPtr_HasFleeSoundEvent;
    [FieldOffset(0)]
    public FmodEventGuid FleeSoundGuid;
    [FieldOffset(16)]
    public int2 MinMaxCritters;
    [FieldOffset(24)]
    public float ResetZoneRadius;
    [FieldOffset(28)]
    public float ActivationZoneRadius;
    [FieldOffset(32)]
    public float EscapeZoneRadius;
    [FieldOffset(36)]
    public float SpawnZoneRadius;
    [FieldOffset(40)]
    public float MaxAliveTime;
    [FieldOffset(44)]
    public float CurrentAliveTime;
    [FieldOffset(48)]
    public PrefabGUID BaseCritterGuid;
    [FieldOffset(52)]
    public int NumCritters;
    [FieldOffset(56)]
    public CritterSphere InnerActiveSphere;
    [FieldOffset(60)]
    public CritterGroupState State;
    [FieldOffset(64)]
    public bool IsTemporary;
    [FieldOffset(65)]
    public bool HasFleeSoundEvent;

    static CritterGroup()
    {
      Il2CppClassPointerStore<CritterGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CritterGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr);
      CritterGroup.NativeFieldInfoPtr_FleeSoundGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, nameof (FleeSoundGuid));
      CritterGroup.NativeFieldInfoPtr_MinMaxCritters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, nameof (MinMaxCritters));
      CritterGroup.NativeFieldInfoPtr_ResetZoneRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, nameof (ResetZoneRadius));
      CritterGroup.NativeFieldInfoPtr_ActivationZoneRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, nameof (ActivationZoneRadius));
      CritterGroup.NativeFieldInfoPtr_EscapeZoneRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, nameof (EscapeZoneRadius));
      CritterGroup.NativeFieldInfoPtr_SpawnZoneRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, nameof (SpawnZoneRadius));
      CritterGroup.NativeFieldInfoPtr_MaxAliveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, nameof (MaxAliveTime));
      CritterGroup.NativeFieldInfoPtr_CurrentAliveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, nameof (CurrentAliveTime));
      CritterGroup.NativeFieldInfoPtr_BaseCritterGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, nameof (BaseCritterGuid));
      CritterGroup.NativeFieldInfoPtr_NumCritters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, nameof (NumCritters));
      CritterGroup.NativeFieldInfoPtr_InnerActiveSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, nameof (InnerActiveSphere));
      CritterGroup.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, nameof (State));
      CritterGroup.NativeFieldInfoPtr_IsTemporary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, nameof (IsTemporary));
      CritterGroup.NativeFieldInfoPtr_HasFleeSoundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, nameof (HasFleeSoundEvent));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CritterGroup>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

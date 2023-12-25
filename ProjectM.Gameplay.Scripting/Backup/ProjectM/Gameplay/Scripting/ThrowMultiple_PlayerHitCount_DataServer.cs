// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.ThrowMultiple_PlayerHitCount_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ThrowMultiple_PlayerHitCount_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetHitFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetFilterCondition;
    private static readonly System.IntPtr NativeFieldInfoPtr_CountVampire_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_CountVampire_Max;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxVampireCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_CountCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_IndividualRandom;
    private static readonly System.IntPtr NativeFieldInfoPtr_AlwaysMaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewThrowEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitCounter;
    [FieldOffset(0)]
    public HitFilter TargetHitFilter;
    [FieldOffset(8)]
    public BlobAssetReference<ConditionBlob> TargetFilterCondition;
    [FieldOffset(16)]
    public int CountVampire_Min;
    [FieldOffset(20)]
    public int CountVampire_Max;
    [FieldOffset(24)]
    public int MaxVampireCount;
    [FieldOffset(28)]
    public CurveReference CountCurve;
    [FieldOffset(36)]
    public float MaxRange;
    [FieldOffset(40)]
    public float RandomAngle;
    [FieldOffset(44)]
    public float OffsetAngle;
    [FieldOffset(48)]
    public bool IndividualRandom;
    [FieldOffset(49)]
    public bool AlwaysMaxRange;
    [FieldOffset(52)]
    public PrefabGUID NewThrowEntity;
    [FieldOffset(56)]
    public int HitCounter;

    static ThrowMultiple_PlayerHitCount_DataServer()
    {
      Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (ThrowMultiple_PlayerHitCount_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr);
      ThrowMultiple_PlayerHitCount_DataServer.NativeFieldInfoPtr_TargetHitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr, nameof (TargetHitFilter));
      ThrowMultiple_PlayerHitCount_DataServer.NativeFieldInfoPtr_TargetFilterCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr, nameof (TargetFilterCondition));
      ThrowMultiple_PlayerHitCount_DataServer.NativeFieldInfoPtr_CountVampire_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr, nameof (CountVampire_Min));
      ThrowMultiple_PlayerHitCount_DataServer.NativeFieldInfoPtr_CountVampire_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr, nameof (CountVampire_Max));
      ThrowMultiple_PlayerHitCount_DataServer.NativeFieldInfoPtr_MaxVampireCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr, nameof (MaxVampireCount));
      ThrowMultiple_PlayerHitCount_DataServer.NativeFieldInfoPtr_CountCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr, nameof (CountCurve));
      ThrowMultiple_PlayerHitCount_DataServer.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr, nameof (MaxRange));
      ThrowMultiple_PlayerHitCount_DataServer.NativeFieldInfoPtr_RandomAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr, nameof (RandomAngle));
      ThrowMultiple_PlayerHitCount_DataServer.NativeFieldInfoPtr_OffsetAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr, nameof (OffsetAngle));
      ThrowMultiple_PlayerHitCount_DataServer.NativeFieldInfoPtr_IndividualRandom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr, nameof (IndividualRandom));
      ThrowMultiple_PlayerHitCount_DataServer.NativeFieldInfoPtr_AlwaysMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr, nameof (AlwaysMaxRange));
      ThrowMultiple_PlayerHitCount_DataServer.NativeFieldInfoPtr_NewThrowEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr, nameof (NewThrowEntity));
      ThrowMultiple_PlayerHitCount_DataServer.NativeFieldInfoPtr_HitCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr, nameof (HitCounter));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ThrowMultiple_PlayerHitCount_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

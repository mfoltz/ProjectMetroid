// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.CastOptionBuffer
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastOptionBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_Probability;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_Cooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_AggroFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_AngleRequirement;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_InterruptOnTargetDeath;
    private static readonly System.IntPtr NativeFieldInfoPtr_LineOfSightRequirement;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeFieldInfoPtr_GroupCondition;
    private static readonly System.IntPtr NativeFieldInfoPtr_SuccessDelay;
    private static readonly System.IntPtr NativeFieldInfoPtr_TieBreaker;
    [FieldOffset(0)]
    public int AbilityIndex;
    [FieldOffset(4)]
    public int Probability;
    [FieldOffset(8)]
    public CastOptionRange Range;
    [FieldOffset(16)]
    public CastOptionCooldown Cooldown;
    [FieldOffset(24)]
    public CastOptionAggroFilter AggroFilter;
    [FieldOffset(28)]
    public CastOptionAngleRequirement AngleRequirement;
    [FieldOffset(32)]
    public CastOptionIgnoreCooldown IgnoreCooldown;
    [FieldOffset(36)]
    public bool InterruptOnTargetDeath;
    [FieldOffset(40)]
    public CastOptionLineOfSightRequirement LineOfSightRequirement;
    [FieldOffset(48)]
    public BlobAssetReference<ConditionBlob> Condition;
    [FieldOffset(56)]
    public BlobAssetReference<ConditionBlob> GroupCondition;
    [FieldOffset(64)]
    public float2 SuccessDelay;
    [FieldOffset(72)]
    public CastOptionTieBreaker TieBreaker;

    static CastOptionBuffer()
    {
      Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (CastOptionBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr);
      CastOptionBuffer.NativeFieldInfoPtr_AbilityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr, nameof (AbilityIndex));
      CastOptionBuffer.NativeFieldInfoPtr_Probability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr, nameof (Probability));
      CastOptionBuffer.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr, nameof (Range));
      CastOptionBuffer.NativeFieldInfoPtr_Cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr, nameof (Cooldown));
      CastOptionBuffer.NativeFieldInfoPtr_AggroFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr, nameof (AggroFilter));
      CastOptionBuffer.NativeFieldInfoPtr_AngleRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr, nameof (AngleRequirement));
      CastOptionBuffer.NativeFieldInfoPtr_IgnoreCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr, nameof (IgnoreCooldown));
      CastOptionBuffer.NativeFieldInfoPtr_InterruptOnTargetDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr, nameof (InterruptOnTargetDeath));
      CastOptionBuffer.NativeFieldInfoPtr_LineOfSightRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr, nameof (LineOfSightRequirement));
      CastOptionBuffer.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr, nameof (Condition));
      CastOptionBuffer.NativeFieldInfoPtr_GroupCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr, nameof (GroupCondition));
      CastOptionBuffer.NativeFieldInfoPtr_SuccessDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr, nameof (SuccessDelay));
      CastOptionBuffer.NativeFieldInfoPtr_TieBreaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr, nameof (TieBreaker));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastOptionBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

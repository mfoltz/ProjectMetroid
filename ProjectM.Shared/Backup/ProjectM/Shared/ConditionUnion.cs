// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ConditionUnion
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ConditionUnion
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Bool;
    private static readonly System.IntPtr NativeFieldInfoPtr_Float;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayTimeSpan;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetBool;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetFloat;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetInt;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetPrefabFloat;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetPrefabInt;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetSpellMod;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntityCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetWeaponType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetUnitHealthType;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetBuffCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetBuffModification;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityTargetPrefabTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityTargetPrefabTimeInvert;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityTargetPrefabCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_DamageTakenSince;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetAiPointOfInterestType;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0;
    [FieldOffset(0)]
    public readonly BoolCondition Bool;
    [FieldOffset(0)]
    public readonly FloatCondition Float;
    [FieldOffset(0)]
    public readonly PrefabCondition Prefab;
    [FieldOffset(0)]
    public readonly DayTimeSpanCondition DayTimeSpan;
    [FieldOffset(0)]
    public readonly TargetBoolCondition TargetBool;
    [FieldOffset(0)]
    public readonly TargetFloatCondition TargetFloat;
    [FieldOffset(0)]
    public readonly TargetIntCondition TargetInt;
    [FieldOffset(0)]
    public readonly TargetPrefabCondition TargetPrefab;
    [FieldOffset(0)]
    public readonly TargetPrefabFloatCondition TargetPrefabFloat;
    [FieldOffset(0)]
    public readonly TargetPrefabIntCondition TargetPrefabInt;
    [FieldOffset(0)]
    public readonly TargetSpellModTypeCondition TargetSpellMod;
    [FieldOffset(0)]
    public readonly TargetEntityCategoryCondition TargetEntityCategory;
    [FieldOffset(0)]
    public readonly TargetWeaponTypeCondition TargetWeaponType;
    [FieldOffset(0)]
    public readonly TargetUnitHealthTypeCondition TargetUnitHealthType;
    [FieldOffset(0)]
    public readonly TargetBuffCategoryCondition TargetBuffCategory;
    [FieldOffset(0)]
    public readonly TargetBuffModificationCondition TargetBuffModification;
    [FieldOffset(0)]
    public readonly AbilityTargetPrefabTimeCondition AbilityTargetPrefabTime;
    [FieldOffset(0)]
    public readonly AbilityTargetPrefabTimeInvertCondition AbilityTargetPrefabTimeInvert;
    [FieldOffset(0)]
    public readonly AbilityTargetPrefabCountCondition AbilityTargetPrefabCount;
    [FieldOffset(0)]
    public readonly DamageTakenSinceCondition DamageTakenSince;
    [FieldOffset(0)]
    public readonly TargetAiPointOfInterestTypeCondition TargetAiPointOfInterestType;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 800650, RefRangeEnd = 800652, XrefRangeStart = 800648, XrefRangeEnd = 800650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConditionUnion(ConditionalAuthoring authoring)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) authoring);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionUnion.NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConditionUnion()
    {
      Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (ConditionUnion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr);
      ConditionUnion.NativeFieldInfoPtr_Bool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (Bool));
      ConditionUnion.NativeFieldInfoPtr_Float = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (Float));
      ConditionUnion.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (Prefab));
      ConditionUnion.NativeFieldInfoPtr_DayTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (DayTimeSpan));
      ConditionUnion.NativeFieldInfoPtr_TargetBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (TargetBool));
      ConditionUnion.NativeFieldInfoPtr_TargetFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (TargetFloat));
      ConditionUnion.NativeFieldInfoPtr_TargetInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (TargetInt));
      ConditionUnion.NativeFieldInfoPtr_TargetPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (TargetPrefab));
      ConditionUnion.NativeFieldInfoPtr_TargetPrefabFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (TargetPrefabFloat));
      ConditionUnion.NativeFieldInfoPtr_TargetPrefabInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (TargetPrefabInt));
      ConditionUnion.NativeFieldInfoPtr_TargetSpellMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (TargetSpellMod));
      ConditionUnion.NativeFieldInfoPtr_TargetEntityCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (TargetEntityCategory));
      ConditionUnion.NativeFieldInfoPtr_TargetWeaponType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (TargetWeaponType));
      ConditionUnion.NativeFieldInfoPtr_TargetUnitHealthType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (TargetUnitHealthType));
      ConditionUnion.NativeFieldInfoPtr_TargetBuffCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (TargetBuffCategory));
      ConditionUnion.NativeFieldInfoPtr_TargetBuffModification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (TargetBuffModification));
      ConditionUnion.NativeFieldInfoPtr_AbilityTargetPrefabTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (AbilityTargetPrefabTime));
      ConditionUnion.NativeFieldInfoPtr_AbilityTargetPrefabTimeInvert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (AbilityTargetPrefabTimeInvert));
      ConditionUnion.NativeFieldInfoPtr_AbilityTargetPrefabCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (AbilityTargetPrefabCount));
      ConditionUnion.NativeFieldInfoPtr_DamageTakenSince = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (DamageTakenSince));
      ConditionUnion.NativeFieldInfoPtr_TargetAiPointOfInterestType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, nameof (TargetAiPointOfInterestType));
      ConditionUnion.NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, 100670628);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConditionUnion>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

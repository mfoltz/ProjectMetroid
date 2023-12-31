// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.AbilityTargetPrefabTimeInvertCondition
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
  public struct AbilityTargetPrefabTimeInvertCondition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Fields;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_Invert;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncludeInterrupted;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeCompare;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0;
    [FieldOffset(0)]
    public readonly ConditionTarget Target;
    [FieldOffset(4)]
    public readonly bool Invert;
    [FieldOffset(5)]
    public readonly bool IncludeInterrupted;
    [FieldOffset(8)]
    public readonly Comparison_Unboxed<float> TimeCompare;
    [FieldOffset(16)]
    public readonly PrefabGUID Prefab;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800640, XrefRangeEnd = 800644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityTargetPrefabTimeInvertCondition(ConditionalAuthoring authoring)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) authoring);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityTargetPrefabTimeInvertCondition.NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityTargetPrefabTimeInvertCondition()
    {
      Il2CppClassPointerStore<AbilityTargetPrefabTimeInvertCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (AbilityTargetPrefabTimeInvertCondition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityTargetPrefabTimeInvertCondition>.NativeClassPtr);
      AbilityTargetPrefabTimeInvertCondition.NativeFieldInfoPtr_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabTimeInvertCondition>.NativeClassPtr, nameof (Fields));
      AbilityTargetPrefabTimeInvertCondition.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabTimeInvertCondition>.NativeClassPtr, nameof (Target));
      AbilityTargetPrefabTimeInvertCondition.NativeFieldInfoPtr_Invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabTimeInvertCondition>.NativeClassPtr, nameof (Invert));
      AbilityTargetPrefabTimeInvertCondition.NativeFieldInfoPtr_IncludeInterrupted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabTimeInvertCondition>.NativeClassPtr, nameof (IncludeInterrupted));
      AbilityTargetPrefabTimeInvertCondition.NativeFieldInfoPtr_TimeCompare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabTimeInvertCondition>.NativeClassPtr, nameof (TimeCompare));
      AbilityTargetPrefabTimeInvertCondition.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabTimeInvertCondition>.NativeClassPtr, nameof (Prefab));
      AbilityTargetPrefabTimeInvertCondition.NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityTargetPrefabTimeInvertCondition>.NativeClassPtr, 100670626);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityTargetPrefabTimeInvertCondition>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe ConditionDataFields Fields
    {
      get
      {
        ConditionDataFields fields;
        IL2CPP.il2cpp_field_static_get_value(AbilityTargetPrefabTimeInvertCondition.NativeFieldInfoPtr_Fields, (void*) &fields);
        return fields;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AbilityTargetPrefabTimeInvertCondition.NativeFieldInfoPtr_Fields, (void*) &value);
      }
    }
  }
}

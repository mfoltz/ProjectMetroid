// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.AbilityTargetPrefabTimeCondition
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
  public struct AbilityTargetPrefabTimeCondition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Fields;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncludeInterrupted;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeCompare;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0;
    [FieldOffset(0)]
    public readonly ConditionTarget Target;
    [FieldOffset(4)]
    public readonly bool IncludeInterrupted;
    [FieldOffset(8)]
    public readonly Comparison_Unboxed<float> TimeCompare;
    [FieldOffset(16)]
    public readonly PrefabGUID Prefab;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 800639, RefRangeEnd = 800640, XrefRangeStart = 800635, XrefRangeEnd = 800639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityTargetPrefabTimeCondition(ConditionalAuthoring authoring)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) authoring);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityTargetPrefabTimeCondition.NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityTargetPrefabTimeCondition()
    {
      Il2CppClassPointerStore<AbilityTargetPrefabTimeCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (AbilityTargetPrefabTimeCondition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityTargetPrefabTimeCondition>.NativeClassPtr);
      AbilityTargetPrefabTimeCondition.NativeFieldInfoPtr_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabTimeCondition>.NativeClassPtr, nameof (Fields));
      AbilityTargetPrefabTimeCondition.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabTimeCondition>.NativeClassPtr, nameof (Target));
      AbilityTargetPrefabTimeCondition.NativeFieldInfoPtr_IncludeInterrupted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabTimeCondition>.NativeClassPtr, nameof (IncludeInterrupted));
      AbilityTargetPrefabTimeCondition.NativeFieldInfoPtr_TimeCompare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabTimeCondition>.NativeClassPtr, nameof (TimeCompare));
      AbilityTargetPrefabTimeCondition.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabTimeCondition>.NativeClassPtr, nameof (Prefab));
      AbilityTargetPrefabTimeCondition.NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityTargetPrefabTimeCondition>.NativeClassPtr, 100670625);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityTargetPrefabTimeCondition>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe ConditionDataFields Fields
    {
      get
      {
        ConditionDataFields fields;
        IL2CPP.il2cpp_field_static_get_value(AbilityTargetPrefabTimeCondition.NativeFieldInfoPtr_Fields, (void*) &fields);
        return fields;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AbilityTargetPrefabTimeCondition.NativeFieldInfoPtr_Fields, (void*) &value);
      }
    }
  }
}

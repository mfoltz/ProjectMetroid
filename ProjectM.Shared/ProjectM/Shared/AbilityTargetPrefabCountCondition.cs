// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.AbilityTargetPrefabCountCondition
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
  public struct AbilityTargetPrefabCountCondition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Fields;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_IncludeInterrupted;
    private static readonly System.IntPtr NativeFieldInfoPtr_CountCompare;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prefab;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0;
    [FieldOffset(0)]
    public readonly ConditionTarget Target;
    [FieldOffset(4)]
    public readonly bool IncludeInterrupted;
    [FieldOffset(8)]
    public readonly Comparison_Unboxed<int> CountCompare;
    [FieldOffset(16)]
    public readonly PrefabGUID Prefab;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800644, XrefRangeEnd = 800648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityTargetPrefabCountCondition(ConditionalAuthoring authoring)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) authoring);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityTargetPrefabCountCondition.NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityTargetPrefabCountCondition()
    {
      Il2CppClassPointerStore<AbilityTargetPrefabCountCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (AbilityTargetPrefabCountCondition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityTargetPrefabCountCondition>.NativeClassPtr);
      AbilityTargetPrefabCountCondition.NativeFieldInfoPtr_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabCountCondition>.NativeClassPtr, nameof (Fields));
      AbilityTargetPrefabCountCondition.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabCountCondition>.NativeClassPtr, nameof (Target));
      AbilityTargetPrefabCountCondition.NativeFieldInfoPtr_IncludeInterrupted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabCountCondition>.NativeClassPtr, nameof (IncludeInterrupted));
      AbilityTargetPrefabCountCondition.NativeFieldInfoPtr_CountCompare = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabCountCondition>.NativeClassPtr, nameof (CountCompare));
      AbilityTargetPrefabCountCondition.NativeFieldInfoPtr_Prefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityTargetPrefabCountCondition>.NativeClassPtr, nameof (Prefab));
      AbilityTargetPrefabCountCondition.NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityTargetPrefabCountCondition>.NativeClassPtr, 100670627);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityTargetPrefabCountCondition>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe ConditionDataFields Fields
    {
      get
      {
        ConditionDataFields fields;
        IL2CPP.il2cpp_field_static_get_value(AbilityTargetPrefabCountCondition.NativeFieldInfoPtr_Fields, (void*) &fields);
        return fields;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AbilityTargetPrefabCountCondition.NativeFieldInfoPtr_Fields, (void*) &value);
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.DayTimeSpanCondition
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
  public struct DayTimeSpanCondition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Fields;
    private static readonly System.IntPtr NativeFieldInfoPtr_Invert;
    private static readonly System.IntPtr NativeFieldInfoPtr_DayTimeSpan;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0;
    [FieldOffset(0)]
    public readonly bool Invert;
    [FieldOffset(4)]
    public readonly DayTimeSpan DayTimeSpan;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 800629, XrefRangeEnd = 800635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DayTimeSpanCondition(ConditionalAuthoring authoring)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) authoring);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DayTimeSpanCondition.NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DayTimeSpanCondition()
    {
      Il2CppClassPointerStore<DayTimeSpanCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (DayTimeSpanCondition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DayTimeSpanCondition>.NativeClassPtr);
      DayTimeSpanCondition.NativeFieldInfoPtr_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpanCondition>.NativeClassPtr, nameof (Fields));
      DayTimeSpanCondition.NativeFieldInfoPtr_Invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpanCondition>.NativeClassPtr, nameof (Invert));
      DayTimeSpanCondition.NativeFieldInfoPtr_DayTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DayTimeSpanCondition>.NativeClassPtr, nameof (DayTimeSpan));
      DayTimeSpanCondition.NativeMethodInfoPtr__ctor_Public_Void_ConditionalAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DayTimeSpanCondition>.NativeClassPtr, 100670618);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DayTimeSpanCondition>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe ConditionDataFields Fields
    {
      get
      {
        ConditionDataFields fields;
        IL2CPP.il2cpp_field_static_get_value(DayTimeSpanCondition.NativeFieldInfoPtr_Fields, (void*) &fields);
        return fields;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DayTimeSpanCondition.NativeFieldInfoPtr_Fields, (void*) &value);
      }
    }
  }
}

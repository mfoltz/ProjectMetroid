// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.FlowEventBlob
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace Stunlock.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FlowEventBlob
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpeedParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_RepeatsParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_FlowType;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpeedMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ConditionsEvaluationMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChildStartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChildCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Conditions;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalRepeats_Public_Static_Int32_byref_FlowEventBlob_byref_Blackboard_0;
    [FieldOffset(0)]
    public BlackboardParameterRuntime SpeedParameter;
    [FieldOffset(4)]
    public BlackboardParameterRuntime RepeatsParameter;
    [FieldOffset(8)]
    public FlowTypeEnum FlowType;
    [FieldOffset(9)]
    public PlayModeEnum PlayMode;
    [FieldOffset(10)]
    public FlowNodeSpeedMode SpeedMode;
    [FieldOffset(11)]
    public ConditionsEvaluationMode ConditionsEvaluationMode;
    [FieldOffset(12)]
    public ushort ChildStartIndex;
    [FieldOffset(14)]
    public ushort ChildCount;
    [FieldOffset(16)]
    public float Speed;
    [FieldOffset(20)]
    public BlobArray<ConditionNew> Conditions;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 923420, RefRangeEnd = 923421, XrefRangeStart = 923419, XrefRangeEnd = 923420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetLocalRepeats(
      ref FlowEventBlob flowEventBlog,
      ref Blackboard blackboard)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref flowEventBlog;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref blackboard;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FlowEventBlob.NativeMethodInfoPtr_GetLocalRepeats_Public_Static_Int32_byref_FlowEventBlob_byref_Blackboard_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static FlowEventBlob()
    {
      Il2CppClassPointerStore<FlowEventBlob>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (FlowEventBlob));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowEventBlob>.NativeClassPtr);
      FlowEventBlob.NativeFieldInfoPtr_SpeedParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBlob>.NativeClassPtr, nameof (SpeedParameter));
      FlowEventBlob.NativeFieldInfoPtr_RepeatsParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBlob>.NativeClassPtr, nameof (RepeatsParameter));
      FlowEventBlob.NativeFieldInfoPtr_FlowType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBlob>.NativeClassPtr, nameof (FlowType));
      FlowEventBlob.NativeFieldInfoPtr_PlayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBlob>.NativeClassPtr, nameof (PlayMode));
      FlowEventBlob.NativeFieldInfoPtr_SpeedMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBlob>.NativeClassPtr, nameof (SpeedMode));
      FlowEventBlob.NativeFieldInfoPtr_ConditionsEvaluationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBlob>.NativeClassPtr, nameof (ConditionsEvaluationMode));
      FlowEventBlob.NativeFieldInfoPtr_ChildStartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBlob>.NativeClassPtr, nameof (ChildStartIndex));
      FlowEventBlob.NativeFieldInfoPtr_ChildCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBlob>.NativeClassPtr, nameof (ChildCount));
      FlowEventBlob.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBlob>.NativeClassPtr, nameof (Speed));
      FlowEventBlob.NativeFieldInfoPtr_Conditions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowEventBlob>.NativeClassPtr, nameof (Conditions));
      FlowEventBlob.NativeMethodInfoPtr_GetLocalRepeats_Public_Static_Int32_byref_FlowEventBlob_byref_Blackboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowEventBlob>.NativeClassPtr, 100663878);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FlowEventBlob>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

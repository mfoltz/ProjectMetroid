// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.EventStruct
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Stunlock.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct EventStruct
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_NodeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlaybackSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastFrameRun;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentLoop;
    private static readonly System.IntPtr NativeFieldInfoPtr_LastOutputIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartedThisFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_DurationParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayInFlyMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsInfiniteDuration;
    private static readonly System.IntPtr NativeMethodInfoPtr_RanLastFrame_Public_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetScaledDuration_Public_Single_byref_Blackboard_0;
    [FieldOffset(0)]
    public float StartTime;
    [FieldOffset(4)]
    public float NodeTime;
    [FieldOffset(8)]
    public float PlaybackSpeed;
    [FieldOffset(12)]
    public int LastFrameRun;
    [FieldOffset(16)]
    public int CurrentLoop;
    [FieldOffset(20)]
    public int LastOutputIndex;
    [FieldOffset(24)]
    public EventStateEnum State;
    [FieldOffset(28)]
    public bool StartedThisFrame;
    [FieldOffset(32)]
    public BlackboardParameterRuntime DurationParameter;
    [FieldOffset(36)]
    public bool PlayInFlyMode;
    [FieldOffset(37)]
    public bool IsInfiniteDuration;

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 924208, RefRangeEnd = 924214, XrefRangeStart = 924208, XrefRangeEnd = 924208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool RanLastFrame(int currentFrame)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &currentFrame;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventStruct.NativeMethodInfoPtr_RanLastFrame_Public_Boolean_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 924217, RefRangeEnd = 924223, XrefRangeStart = 924214, XrefRangeEnd = 924217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetScaledDuration([In] ref Blackboard blackboard)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref blackboard;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EventStruct.NativeMethodInfoPtr_GetScaledDuration_Public_Single_byref_Blackboard_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EventStruct()
    {
      Il2CppClassPointerStore<EventStruct>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (EventStruct));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventStruct>.NativeClassPtr);
      EventStruct.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventStruct>.NativeClassPtr, nameof (StartTime));
      EventStruct.NativeFieldInfoPtr_NodeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventStruct>.NativeClassPtr, nameof (NodeTime));
      EventStruct.NativeFieldInfoPtr_PlaybackSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventStruct>.NativeClassPtr, nameof (PlaybackSpeed));
      EventStruct.NativeFieldInfoPtr_LastFrameRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventStruct>.NativeClassPtr, nameof (LastFrameRun));
      EventStruct.NativeFieldInfoPtr_CurrentLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventStruct>.NativeClassPtr, nameof (CurrentLoop));
      EventStruct.NativeFieldInfoPtr_LastOutputIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventStruct>.NativeClassPtr, nameof (LastOutputIndex));
      EventStruct.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventStruct>.NativeClassPtr, nameof (State));
      EventStruct.NativeFieldInfoPtr_StartedThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventStruct>.NativeClassPtr, nameof (StartedThisFrame));
      EventStruct.NativeFieldInfoPtr_DurationParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventStruct>.NativeClassPtr, nameof (DurationParameter));
      EventStruct.NativeFieldInfoPtr_PlayInFlyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventStruct>.NativeClassPtr, nameof (PlayInFlyMode));
      EventStruct.NativeFieldInfoPtr_IsInfiniteDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventStruct>.NativeClassPtr, nameof (IsInfiniteDuration));
      EventStruct.NativeMethodInfoPtr_RanLastFrame_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventStruct>.NativeClassPtr, 100663918);
      EventStruct.NativeMethodInfoPtr_GetScaledDuration_Public_Single_byref_Blackboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventStruct>.NativeClassPtr, 100663919);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventStruct>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

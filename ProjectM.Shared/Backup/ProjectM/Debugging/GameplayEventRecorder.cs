// Decompiled with JetBrains decompiler
// Type: ProjectM.Debugging.GameplayEventRecorder
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct GameplayEventRecorder
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayDebugRecorder;
    private static readonly System.IntPtr NativeFieldInfoPtr_Index;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecordingDisabled;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetResult_Public_Void_GameplayEventResultEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetApplyBuffResult_Public_Void_ApplyBuffResult_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public GameplayDebugRecorder GameplayDebugRecorder;
    [FieldOffset(40)]
    public int Index;
    [FieldOffset(44)]
    public bool RecordingDisabled;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 770559, RefRangeEnd = 770562, XrefRangeStart = 770546, XrefRangeEnd = 770559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetResult(GameplayEventResultEnum resultEnum)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &resultEnum;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayEventRecorder.NativeMethodInfoPtr_SetResult_Public_Void_GameplayEventResultEnum_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770575, RefRangeEnd = 770576, XrefRangeStart = 770562, XrefRangeEnd = 770575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetApplyBuffResult(ApplyBuffResult applyBuffResult)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &applyBuffResult;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayEventRecorder.NativeMethodInfoPtr_SetApplyBuffResult_Public_Void_ApplyBuffResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 770586, RefRangeEnd = 770587, XrefRangeStart = 770576, XrefRangeEnd = 770586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayEventRecorder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameplayEventRecorder()
    {
      Il2CppClassPointerStore<GameplayEventRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Debugging", nameof (GameplayEventRecorder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayEventRecorder>.NativeClassPtr);
      GameplayEventRecorder.NativeFieldInfoPtr_GameplayDebugRecorder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventRecorder>.NativeClassPtr, nameof (GameplayDebugRecorder));
      GameplayEventRecorder.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventRecorder>.NativeClassPtr, nameof (Index));
      GameplayEventRecorder.NativeFieldInfoPtr_RecordingDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayEventRecorder>.NativeClassPtr, nameof (RecordingDisabled));
      GameplayEventRecorder.NativeMethodInfoPtr_SetResult_Public_Void_GameplayEventResultEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventRecorder>.NativeClassPtr, 100668242);
      GameplayEventRecorder.NativeMethodInfoPtr_SetApplyBuffResult_Public_Void_ApplyBuffResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventRecorder>.NativeClassPtr, 100668243);
      GameplayEventRecorder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventRecorder>.NativeClassPtr, 100668244);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameplayEventRecorder>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

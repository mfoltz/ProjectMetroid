// Decompiled with JetBrains decompiler
// Type: ProjectM.Debugging.RecordedFrame
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Debugging
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RecordedFrame
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Records;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entities;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
    [FieldOffset(0)]
    public NativeList<GameplayDebugRecord> Records;
    [FieldOffset(16)]
    public NativeHashSet<Entity> Entities;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769992, RefRangeEnd = 769993, XrefRangeStart = 769986, XrefRangeEnd = 769992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecordedFrame.NativeMethodInfoPtr_Clear_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769999, RefRangeEnd = 770000, XrefRangeStart = 769993, XrefRangeEnd = 769999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecordedFrame.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RecordedFrame()
    {
      Il2CppClassPointerStore<RecordedFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Debugging", nameof (RecordedFrame));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecordedFrame>.NativeClassPtr);
      RecordedFrame.NativeFieldInfoPtr_Records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordedFrame>.NativeClassPtr, nameof (Records));
      RecordedFrame.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordedFrame>.NativeClassPtr, nameof (Entities));
      RecordedFrame.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordedFrame>.NativeClassPtr, 100668164);
      RecordedFrame.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordedFrame>.NativeClassPtr, 100668165);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RecordedFrame>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

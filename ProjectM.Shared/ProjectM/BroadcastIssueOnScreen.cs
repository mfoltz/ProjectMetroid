// Decompiled with JetBrains decompiler
// Type: ProjectM.BroadcastIssueOnScreen
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BroadcastIssueOnScreen
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Ref;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventStack;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UnsafeList_1_EventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Push_Public_Static_Void_WorldType_BroadcastIssueId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetFrame_Internal_Void_byref_Int64_byref_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasEvents_Internal_Boolean_0;
    [FieldOffset(0)]
    public DebugEventStack<BroadcastIssueOnScreen.EventData> _EventStack;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 732862, RefRangeEnd = 732864, XrefRangeStart = 732859, XrefRangeEnd = 732862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BroadcastIssueOnScreen(UnsafeList<BroadcastIssueOnScreen.EventData> data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BroadcastIssueOnScreen.NativeMethodInfoPtr__ctor_Internal_Void_UnsafeList_1_EventData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732864, XrefRangeEnd = 732874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Push(WorldType fromWorldType, BroadcastIssueId issueId)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &fromWorldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &issueId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BroadcastIssueOnScreen.NativeMethodInfoPtr_Push_Public_Static_Void_WorldType_BroadcastIssueId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 732882, RefRangeEnd = 732883, XrefRangeStart = 732874, XrefRangeEnd = 732882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetFrame(out long unconsumedEventCount, out long eventsRequestedForFrame)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref unconsumedEventCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventsRequestedForFrame;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BroadcastIssueOnScreen.NativeMethodInfoPtr_ResetFrame_Internal_Void_byref_Int64_byref_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 732886, RefRangeEnd = 732887, XrefRangeStart = 732883, XrefRangeEnd = 732886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasEvents()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BroadcastIssueOnScreen.NativeMethodInfoPtr_HasEvents_Internal_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BroadcastIssueOnScreen()
    {
      Il2CppClassPointerStore<BroadcastIssueOnScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BroadcastIssueOnScreen));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BroadcastIssueOnScreen>.NativeClassPtr);
      BroadcastIssueOnScreen.NativeFieldInfoPtr_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastIssueOnScreen>.NativeClassPtr, nameof (Ref));
      BroadcastIssueOnScreen.NativeFieldInfoPtr__EventStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastIssueOnScreen>.NativeClassPtr, nameof (_EventStack));
      BroadcastIssueOnScreen.NativeMethodInfoPtr__ctor_Internal_Void_UnsafeList_1_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastIssueOnScreen>.NativeClassPtr, 100664770);
      BroadcastIssueOnScreen.NativeMethodInfoPtr_Push_Public_Static_Void_WorldType_BroadcastIssueId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastIssueOnScreen>.NativeClassPtr, 100664771);
      BroadcastIssueOnScreen.NativeMethodInfoPtr_ResetFrame_Internal_Void_byref_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastIssueOnScreen>.NativeClassPtr, 100664772);
      BroadcastIssueOnScreen.NativeMethodInfoPtr_HasEvents_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BroadcastIssueOnScreen>.NativeClassPtr, 100664773);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BroadcastIssueOnScreen>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe SharedStatic<BroadcastIssueOnScreen> Ref
    {
      get
      {
        SharedStatic<BroadcastIssueOnScreen> sharedStatic;
        IL2CPP.il2cpp_field_static_get_value(BroadcastIssueOnScreen.NativeFieldInfoPtr_Ref, (void*) &sharedStatic);
        return sharedStatic;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BroadcastIssueOnScreen.NativeFieldInfoPtr_Ref, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EventData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_FromWorldType;
      private static readonly System.IntPtr NativeFieldInfoPtr_IssueId;
      [FieldOffset(0)]
      public WorldType FromWorldType;
      [FieldOffset(4)]
      public BroadcastIssueId IssueId;

      static EventData()
      {
        Il2CppClassPointerStore<BroadcastIssueOnScreen.EventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BroadcastIssueOnScreen>.NativeClassPtr, nameof (EventData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BroadcastIssueOnScreen.EventData>.NativeClassPtr);
        BroadcastIssueOnScreen.EventData.NativeFieldInfoPtr_FromWorldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastIssueOnScreen.EventData>.NativeClassPtr, nameof (FromWorldType));
        BroadcastIssueOnScreen.EventData.NativeFieldInfoPtr_IssueId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BroadcastIssueOnScreen.EventData>.NativeClassPtr, nameof (IssueId));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BroadcastIssueOnScreen.EventData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}

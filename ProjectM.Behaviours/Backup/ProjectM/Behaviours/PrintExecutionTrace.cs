// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.PrintExecutionTrace
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PrintExecutionTrace
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrintInitialize;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrintTick;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrintAbort;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksRegister;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    [FieldOffset(0)]
    public FixedString64 Id;
    [FieldOffset(64)]
    public bool PrintInitialize;
    [FieldOffset(65)]
    public bool PrintTick;
    [FieldOffset(66)]
    public bool PrintAbort;
    [FieldOffset(68)]
    public PrivateField<int> TicksRegister;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345427, XrefRangeEnd = 1345440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Initialize(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrintExecutionTrace.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345440, XrefRangeEnd = 1345459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Tick(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrintExecutionTrace.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1345475, RefRangeEnd = 1345476, XrefRangeStart = 1345459, XrefRangeEnd = 1345475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Abort(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrintExecutionTrace.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrintExecutionTrace()
    {
      Il2CppClassPointerStore<PrintExecutionTrace>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (PrintExecutionTrace));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrintExecutionTrace>.NativeClassPtr);
      PrintExecutionTrace.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrintExecutionTrace>.NativeClassPtr, nameof (Id));
      PrintExecutionTrace.NativeFieldInfoPtr_PrintInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrintExecutionTrace>.NativeClassPtr, nameof (PrintInitialize));
      PrintExecutionTrace.NativeFieldInfoPtr_PrintTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrintExecutionTrace>.NativeClassPtr, nameof (PrintTick));
      PrintExecutionTrace.NativeFieldInfoPtr_PrintAbort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrintExecutionTrace>.NativeClassPtr, nameof (PrintAbort));
      PrintExecutionTrace.NativeFieldInfoPtr_TicksRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrintExecutionTrace>.NativeClassPtr, nameof (TicksRegister));
      PrintExecutionTrace.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrintExecutionTrace>.NativeClassPtr, 100665535);
      PrintExecutionTrace.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrintExecutionTrace>.NativeClassPtr, 100665536);
      PrintExecutionTrace.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrintExecutionTrace>.NativeClassPtr, 100665537);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrintExecutionTrace>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

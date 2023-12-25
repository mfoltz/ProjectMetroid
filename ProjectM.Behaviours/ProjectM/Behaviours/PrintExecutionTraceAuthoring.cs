// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.PrintExecutionTraceAuthoring
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Behaviours
{
  public class PrintExecutionTraceAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Id;
    private static readonly IntPtr NativeFieldInfoPtr_PrintInitialize;
    private static readonly IntPtr NativeFieldInfoPtr_PrintTick;
    private static readonly IntPtr NativeFieldInfoPtr_PrintAbort;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FixedString64_Boolean_Boolean_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339075, XrefRangeEnd = 1339079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrintExecutionTraceAuthoring(
      FixedString64 id,
      bool printInitialize = true,
      bool printTick = true,
      bool printAbort = true)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrintExecutionTraceAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &id;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &printInitialize;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &printTick;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &printAbort;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrintExecutionTraceAuthoring.NativeMethodInfoPtr__ctor_Public_Void_FixedString64_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339079, XrefRangeEnd = 1339090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrintExecutionTraceAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PrintExecutionTraceAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static PrintExecutionTraceAuthoring()
    {
      Il2CppClassPointerStore<PrintExecutionTraceAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (PrintExecutionTraceAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrintExecutionTraceAuthoring>.NativeClassPtr);
      PrintExecutionTraceAuthoring.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrintExecutionTraceAuthoring>.NativeClassPtr, nameof (Id));
      PrintExecutionTraceAuthoring.NativeFieldInfoPtr_PrintInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrintExecutionTraceAuthoring>.NativeClassPtr, nameof (PrintInitialize));
      PrintExecutionTraceAuthoring.NativeFieldInfoPtr_PrintTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrintExecutionTraceAuthoring>.NativeClassPtr, nameof (PrintTick));
      PrintExecutionTraceAuthoring.NativeFieldInfoPtr_PrintAbort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrintExecutionTraceAuthoring>.NativeClassPtr, nameof (PrintAbort));
      PrintExecutionTraceAuthoring.NativeMethodInfoPtr__ctor_Public_Void_FixedString64_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrintExecutionTraceAuthoring>.NativeClassPtr, 100664873);
      PrintExecutionTraceAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrintExecutionTraceAuthoring>.NativeClassPtr, 100664874);
      PrintExecutionTraceAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrintExecutionTraceAuthoring>.NativeClassPtr, 100664875);
    }

    public PrintExecutionTraceAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FixedString64 Id
    {
      get
      {
        return *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrintExecutionTraceAuthoring.NativeFieldInfoPtr_Id));
      }
      [param: In] set
      {
        *(FixedString64*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrintExecutionTraceAuthoring.NativeFieldInfoPtr_Id)) = value;
      }
    }

    public unsafe bool PrintInitialize
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrintExecutionTraceAuthoring.NativeFieldInfoPtr_PrintInitialize));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrintExecutionTraceAuthoring.NativeFieldInfoPtr_PrintInitialize)) = value;
      }
    }

    public unsafe bool PrintTick
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrintExecutionTraceAuthoring.NativeFieldInfoPtr_PrintTick));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrintExecutionTraceAuthoring.NativeFieldInfoPtr_PrintTick)) = value;
      }
    }

    public unsafe bool PrintAbort
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrintExecutionTraceAuthoring.NativeFieldInfoPtr_PrintAbort));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrintExecutionTraceAuthoring.NativeFieldInfoPtr_PrintAbort)) = value;
      }
    }
  }
}

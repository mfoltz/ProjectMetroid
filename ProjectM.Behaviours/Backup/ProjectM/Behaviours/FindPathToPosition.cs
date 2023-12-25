// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.FindPathToPosition
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FindPathToPosition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxExpansionsOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetPosRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_PathRequestEntityRegister;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    [FieldOffset(0)]
    public int MaxExpansionsOverride;
    [FieldOffset(4)]
    public SharedField<float3> TargetPosRegister;
    [FieldOffset(8)]
    public SharedField<Entity> PathRequestEntityRegister;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1344588, RefRangeEnd = 1344589, XrefRangeStart = 1344572, XrefRangeEnd = 1344588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Initialize(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FindPathToPosition.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344589, XrefRangeEnd = 1344610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Tick(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FindPathToPosition.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344610, XrefRangeEnd = 1344626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Abort(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FindPathToPosition.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FindPathToPosition()
    {
      Il2CppClassPointerStore<FindPathToPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (FindPathToPosition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FindPathToPosition>.NativeClassPtr);
      FindPathToPosition.NativeFieldInfoPtr_MaxExpansionsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindPathToPosition>.NativeClassPtr, nameof (MaxExpansionsOverride));
      FindPathToPosition.NativeFieldInfoPtr_TargetPosRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindPathToPosition>.NativeClassPtr, nameof (TargetPosRegister));
      FindPathToPosition.NativeFieldInfoPtr_PathRequestEntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindPathToPosition>.NativeClassPtr, nameof (PathRequestEntityRegister));
      FindPathToPosition.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindPathToPosition>.NativeClassPtr, 100665449);
      FindPathToPosition.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindPathToPosition>.NativeClassPtr, 100665450);
      FindPathToPosition.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindPathToPosition>.NativeClassPtr, 100665451);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FindPathToPosition>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

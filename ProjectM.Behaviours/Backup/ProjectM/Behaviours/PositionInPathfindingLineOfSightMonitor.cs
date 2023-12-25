// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.PositionInPathfindingLineOfSightMonitor
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PositionInPathfindingLineOfSightMonitor
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Invert;
    private static readonly System.IntPtr NativeFieldInfoPtr_Condition;
    private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    [FieldOffset(0)]
    public bool Invert;
    [FieldOffset(4)]
    public PositionInPathfindingLineOfSight Condition;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338903, XrefRangeEnd = 1338906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Tick(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PositionInPathfindingLineOfSightMonitor.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PositionInPathfindingLineOfSightMonitor()
    {
      Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (PositionInPathfindingLineOfSightMonitor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitor>.NativeClassPtr);
      PositionInPathfindingLineOfSightMonitor.NativeFieldInfoPtr_Invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitor>.NativeClassPtr, nameof (Invert));
      PositionInPathfindingLineOfSightMonitor.NativeFieldInfoPtr_Condition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitor>.NativeClassPtr, nameof (Condition));
      PositionInPathfindingLineOfSightMonitor.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitor>.NativeClassPtr, 100664836);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitor>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

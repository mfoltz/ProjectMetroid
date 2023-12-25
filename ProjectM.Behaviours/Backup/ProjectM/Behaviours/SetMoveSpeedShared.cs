// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.SetMoveSpeedShared
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM.Behaviours
{
  public static class SetMoveSpeedShared : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMoveSpeed_Public_Static_BehaviourTreeResult_Single_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetMoveSpeed_Public_Static_BehaviourTreeResult_AiMoveSpeed_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1345696, RefRangeEnd = 1345700, XrefRangeStart = 1345686, XrefRangeEnd = 1345696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeResult SetMoveSpeed(
      float speed,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &speed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetMoveSpeedShared.NativeMethodInfoPtr_SetMoveSpeed_Public_Static_BehaviourTreeResult_Single_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345700, XrefRangeEnd = 1345705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BehaviourTreeResult SetMoveSpeed(
      AiMoveSpeed speed,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &speed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SetMoveSpeedShared.NativeMethodInfoPtr_SetMoveSpeed_Public_Static_BehaviourTreeResult_AiMoveSpeed_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SetMoveSpeedShared()
    {
      Il2CppClassPointerStore<SetMoveSpeedShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (SetMoveSpeedShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetMoveSpeedShared>.NativeClassPtr);
      SetMoveSpeedShared.NativeMethodInfoPtr_SetMoveSpeed_Public_Static_BehaviourTreeResult_Single_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMoveSpeedShared>.NativeClassPtr, 100665549);
      SetMoveSpeedShared.NativeMethodInfoPtr_SetMoveSpeed_Public_Static_BehaviourTreeResult_AiMoveSpeed_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMoveSpeedShared>.NativeClassPtr, 100665550);
    }

    public SetMoveSpeedShared(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}

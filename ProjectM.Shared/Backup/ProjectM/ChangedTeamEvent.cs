// Decompiled with JetBrains decompiler
// Type: ProjectM.ChangedTeamEvent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ChangedTeamEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEvent_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEvent_Public_Static_Void_EntityCommandBuffer_Entity_0;
    [FieldOffset(0)]
    public Entity Entity;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 731070, RefRangeEnd = 731075, XrefRangeStart = 731066, XrefRangeEnd = 731070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateEvent(EntityManager entityManager, Entity userEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChangedTeamEvent.NativeMethodInfoPtr_CreateEvent_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 731075, XrefRangeEnd = 731079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateEvent(EntityCommandBuffer commandBuffer, Entity userEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &userEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChangedTeamEvent.NativeMethodInfoPtr_CreateEvent_Public_Static_Void_EntityCommandBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChangedTeamEvent()
    {
      Il2CppClassPointerStore<ChangedTeamEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ChangedTeamEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangedTeamEvent>.NativeClassPtr);
      ChangedTeamEvent.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangedTeamEvent>.NativeClassPtr, nameof (Entity));
      ChangedTeamEvent.NativeMethodInfoPtr_CreateEvent_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangedTeamEvent>.NativeClassPtr, 100664633);
      ChangedTeamEvent.NativeMethodInfoPtr_CreateEvent_Public_Static_Void_EntityCommandBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangedTeamEvent>.NativeClassPtr, 100664634);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangedTeamEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

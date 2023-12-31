// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.ExtendedGameManager
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace ProjectM.Scripting
{
  public static class ExtendedGameManager : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_SetBehaviourTreeState_Public_Static_Void_byref_ServerGameManager_Entity_GenericEnemyState_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 773812, RefRangeEnd = 773813, XrefRangeStart = 773808, XrefRangeEnd = 773812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetBehaviourTreeState(
      ref ServerGameManager game,
      Entity target,
      GenericEnemyState state)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref game;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExtendedGameManager.NativeMethodInfoPtr_SetBehaviourTreeState_Public_Static_Void_byref_ServerGameManager_Entity_GenericEnemyState_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ExtendedGameManager()
    {
      Il2CppClassPointerStore<ExtendedGameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (ExtendedGameManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExtendedGameManager>.NativeClassPtr);
      ExtendedGameManager.NativeMethodInfoPtr_SetBehaviourTreeState_Public_Static_Void_byref_ServerGameManager_Entity_GenericEnemyState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExtendedGameManager>.NativeClassPtr, 100668577);
    }

    public ExtendedGameManager(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}

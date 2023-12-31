// Decompiled with JetBrains decompiler
// Type: ProjectM.Debugging.GameplayEventRecordsUpdate
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Debugging
{
  public sealed class GameplayEventRecordsUpdate : Il2CppSystem.MulticastDelegate
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_EntityManager_RecordedFrame_List_1_SystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_EntityManager_RecordedFrame_List_1_SystemBase_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

    [CallerCount(5227)]
    [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameplayEventRecordsUpdate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayEventRecordsUpdate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayEventRecordsUpdate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769978, RefRangeEnd = 769979, XrefRangeStart = 769958, XrefRangeEnd = 769978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Invoke(
      EntityManager entityManager,
      RecordedFrame recordedFrame,
      List<SystemBase> Systems)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &recordedFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) Systems);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayEventRecordsUpdate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_EntityManager_RecordedFrame_List_1_SystemBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769979, XrefRangeEnd = 769986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      EntityManager entityManager,
      RecordedFrame recordedFrame,
      List<SystemBase> Systems,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &recordedFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) Systems);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameplayEventRecordsUpdate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_EntityManager_RecordedFrame_List_1_SystemBase_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : new Il2CppSystem.IAsyncResult(pointer);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 29036, RefRangeEnd = 29039, XrefRangeStart = 29036, XrefRangeEnd = 29039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameplayEventRecordsUpdate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameplayEventRecordsUpdate()
    {
      Il2CppClassPointerStore<GameplayEventRecordsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Debugging", nameof (GameplayEventRecordsUpdate));
      GameplayEventRecordsUpdate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventRecordsUpdate>.NativeClassPtr, 100668160);
      GameplayEventRecordsUpdate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_EntityManager_RecordedFrame_List_1_SystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventRecordsUpdate>.NativeClassPtr, 100668161);
      GameplayEventRecordsUpdate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_EntityManager_RecordedFrame_List_1_SystemBase_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventRecordsUpdate>.NativeClassPtr, 100668162);
      GameplayEventRecordsUpdate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayEventRecordsUpdate>.NativeClassPtr, 100668163);
    }

    public GameplayEventRecordsUpdate(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static implicit operator GameplayEventRecordsUpdate(
      [In] System.Action<EntityManager, RecordedFrame, List<SystemBase>> obj0)
    {
      return DelegateSupport.ConvertDelegate<GameplayEventRecordsUpdate>((System.Delegate) obj0);
    }

    public static GameplayEventRecordsUpdate operator +(
      [In] GameplayEventRecordsUpdate obj0,
      [In] GameplayEventRecordsUpdate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<GameplayEventRecordsUpdate>();
    }

    public static GameplayEventRecordsUpdate operator -(
      [In] GameplayEventRecordsUpdate obj0,
      [In] GameplayEventRecordsUpdate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (GameplayEventRecordsUpdate) @delegate : @delegate.Cast<GameplayEventRecordsUpdate>();
    }
  }
}

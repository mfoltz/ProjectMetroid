// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.AIDebugUtility
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  public static class AIDebugUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultSnapshotCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDebugTarget_Public_Static_Void_EntityManager_Entity_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveDebugTarget_Public_Static_Void_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllComponents_Private_Static_Void_EntityManager_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342778, XrefRangeEnd = 1342823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetDebugTarget(
      EntityManager entityManager,
      Entity target,
      int scrubSnapshotCount = 1800)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &scrubSnapshotCount;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AIDebugUtility.NativeMethodInfoPtr_SetDebugTarget_Public_Static_Void_EntityManager_Entity_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1342823, XrefRangeEnd = 1342835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveDebugTarget(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AIDebugUtility.NativeMethodInfoPtr_RemoveDebugTarget_Public_Static_Void_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1342852, RefRangeEnd = 1342854, XrefRangeStart = 1342835, XrefRangeEnd = 1342852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveAllComponents<T>(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AIDebugUtility.MethodInfoStoreGeneric_RemoveAllComponents_Private_Static_Void_EntityManager_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AIDebugUtility()
    {
      Il2CppClassPointerStore<AIDebugUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (AIDebugUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIDebugUtility>.NativeClassPtr);
      AIDebugUtility.NativeFieldInfoPtr_DefaultSnapshotCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AIDebugUtility>.NativeClassPtr, nameof (DefaultSnapshotCount));
      AIDebugUtility.NativeMethodInfoPtr_SetDebugTarget_Public_Static_Void_EntityManager_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIDebugUtility>.NativeClassPtr, 100665273);
      AIDebugUtility.NativeMethodInfoPtr_RemoveDebugTarget_Public_Static_Void_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIDebugUtility>.NativeClassPtr, 100665274);
      AIDebugUtility.NativeMethodInfoPtr_RemoveAllComponents_Private_Static_Void_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AIDebugUtility>.NativeClassPtr, 100665275);
    }

    public AIDebugUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int DefaultSnapshotCount
    {
      get
      {
        int defaultSnapshotCount;
        IL2CPP.il2cpp_field_static_get_value(AIDebugUtility.NativeFieldInfoPtr_DefaultSnapshotCount, (void*) &defaultSnapshotCount);
        return defaultSnapshotCount;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AIDebugUtility.NativeFieldInfoPtr_DefaultSnapshotCount, (void*) &value);
      }
    }

    private sealed class MethodInfoStoreGeneric_RemoveAllComponents_Private_Static_Void_EntityManager_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(AIDebugUtility.NativeMethodInfoPtr_RemoveAllComponents_Private_Static_Void_EntityManager_0, Il2CppClassPointerStore<AIDebugUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}

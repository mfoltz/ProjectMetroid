// Decompiled with JetBrains decompiler
// Type: ProjectM.SharedModifiableFunctions
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
  public static class SharedModifiableFunctions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNewModifiableValueId_Public_Static_UInt16_EntityManager_Entity_0;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 742969, RefRangeEnd = 742977, XrefRangeStart = 742956, XrefRangeEnd = 742969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ushort GetNewModifiableValueId(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SharedModifiableFunctions.NativeMethodInfoPtr_GetNewModifiableValueId_Public_Static_UInt16_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ushort*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SharedModifiableFunctions()
    {
      Il2CppClassPointerStore<SharedModifiableFunctions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SharedModifiableFunctions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedModifiableFunctions>.NativeClassPtr);
      SharedModifiableFunctions.NativeMethodInfoPtr_GetNewModifiableValueId_Public_Static_UInt16_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedModifiableFunctions>.NativeClassPtr, 100665504);
    }

    public SharedModifiableFunctions(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ModifiableValueIds
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_IdCounter;
      [FieldOffset(0)]
      public ushort IdCounter;

      static ModifiableValueIds()
      {
        Il2CppClassPointerStore<SharedModifiableFunctions.ModifiableValueIds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SharedModifiableFunctions>.NativeClassPtr, nameof (ModifiableValueIds));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedModifiableFunctions.ModifiableValueIds>.NativeClassPtr);
        SharedModifiableFunctions.ModifiableValueIds.NativeFieldInfoPtr_IdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedModifiableFunctions.ModifiableValueIds>.NativeClassPtr, nameof (IdCounter));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SharedModifiableFunctions.ModifiableValueIds>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}

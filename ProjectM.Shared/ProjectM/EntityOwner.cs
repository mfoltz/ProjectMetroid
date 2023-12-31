// Decompiled with JetBrains decompiler
// Type: ProjectM.EntityOwner
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
  public struct EntityOwner
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Owner;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_EntityOwner_0;
    [FieldOffset(0)]
    public Entity Owner;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator Entity(EntityOwner entityOwner)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityOwner;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EntityOwner.NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_EntityOwner_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EntityOwner()
    {
      Il2CppClassPointerStore<EntityOwner>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EntityOwner));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityOwner>.NativeClassPtr);
      EntityOwner.NativeFieldInfoPtr_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityOwner>.NativeClassPtr, nameof (Owner));
      EntityOwner.NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityOwner>.NativeClassPtr, 100664049);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EntityOwner>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

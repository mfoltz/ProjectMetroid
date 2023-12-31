// Decompiled with JetBrains decompiler
// Type: ProjectM.SequenceState
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
  public struct SequenceState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_SequenceState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_SequenceState_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SequenceState_Entity_0;
    [FieldOffset(0)]
    public Entity Id;

    public static unsafe SequenceState Null
    {
      [CallerCount(1474), CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceState.NativeMethodInfoPtr_get_Null_Public_Static_get_SequenceState_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SequenceState*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe bool IsEmpty
    {
      [CallerCount(116), CachedScanResults(RefRangeStart = 747984, RefRangeEnd = 748100, XrefRangeStart = 747982, XrefRangeEnd = 747984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceState.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator Entity(SequenceState state)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &state;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceState.NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_SequenceState_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator SequenceState(Entity id)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &id;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SequenceState.NativeMethodInfoPtr_op_Implicit_Public_Static_SequenceState_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SequenceState*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SequenceState()
    {
      Il2CppClassPointerStore<SequenceState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SequenceState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceState>.NativeClassPtr);
      SequenceState.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceState>.NativeClassPtr, nameof (Id));
      SequenceState.NativeMethodInfoPtr_get_Null_Public_Static_get_SequenceState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceState>.NativeClassPtr, 100665879);
      SequenceState.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceState>.NativeClassPtr, 100665880);
      SequenceState.NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_SequenceState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceState>.NativeClassPtr, 100665881);
      SequenceState.NativeMethodInfoPtr_op_Implicit_Public_Static_SequenceState_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceState>.NativeClassPtr, 100665882);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SequenceState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.ListenerId
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ListenerId
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ListenerId_ListenerId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ListenerId_ListenerId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ListenerId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public Entity Value;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774519, XrefRangeEnd = 774520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(ListenerId lhs, ListenerId rhs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &lhs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ListenerId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ListenerId_ListenerId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 774521, RefRangeEnd = 774528, XrefRangeStart = 774520, XrefRangeEnd = 774521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(ListenerId lhs, ListenerId rhs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &lhs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ListenerId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ListenerId_ListenerId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 378387, RefRangeEnd = 378388, XrefRangeStart = 378387, XrefRangeEnd = 378388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(ListenerId other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ListenerId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ListenerId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774528, XrefRangeEnd = 774534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object compare)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compare);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ListenerId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(409)]
    [CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ListenerId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ListenerId()
    {
      Il2CppClassPointerStore<ListenerId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (ListenerId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListenerId>.NativeClassPtr);
      ListenerId.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ListenerId>.NativeClassPtr, nameof (Value));
      ListenerId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ListenerId_ListenerId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerId>.NativeClassPtr, 100668630);
      ListenerId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ListenerId_ListenerId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerId>.NativeClassPtr, 100668631);
      ListenerId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ListenerId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerId>.NativeClassPtr, 100668632);
      ListenerId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerId>.NativeClassPtr, 100668633);
      ListenerId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListenerId>.NativeClassPtr, 100668634);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ListenerId>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

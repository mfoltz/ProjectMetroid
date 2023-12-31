// Decompiled with JetBrains decompiler
// Type: ProjectM.Physics.FrontFaceClosestHitCollector
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Physics;

#nullable disable
namespace ProjectM.Physics
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FrontFaceClosestHitCollector
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__MaxFraction_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__NumHits_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_Bodies;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hits;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EarlyOutOnFirstHit_Public_Virtual_Final_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxFraction_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxFraction_Private_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NumHits_Public_Virtual_Final_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_NumHits_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_NativeSlice_1_RigidBody_byref_NativeList_1_RaycastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHit_Public_Virtual_Final_New_Boolean_RaycastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsFrontFaceHit_Private_Boolean_RaycastHit_0;
    [FieldOffset(0)]
    public float _MaxFraction_k__BackingField;
    [FieldOffset(4)]
    public int _NumHits_k__BackingField;
    [FieldOffset(8)]
    public NativeSlice<RigidBody> Bodies;
    [FieldOffset(24)]
    public NativeList<RaycastHit> Hits;

    public virtual unsafe bool EarlyOutOnFirstHit
    {
      [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FrontFaceClosestHitCollector.NativeMethodInfoPtr_get_EarlyOutOnFirstHit_Public_Virtual_Final_New_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public virtual unsafe float MaxFraction
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 538356, RefRangeEnd = 538358, XrefRangeStart = 538356, XrefRangeEnd = 538358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FrontFaceClosestHitCollector.NativeMethodInfoPtr_get_MaxFraction_Public_Virtual_Final_New_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(32), CachedScanResults(RefRangeStart = 195710, RefRangeEnd = 195742, XrefRangeStart = 195710, XrefRangeEnd = 195742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FrontFaceClosestHitCollector.NativeMethodInfoPtr_set_MaxFraction_Private_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe int NumHits
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FrontFaceClosestHitCollector.NativeMethodInfoPtr_get_NumHits_Public_Virtual_Final_New_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 204767, RefRangeEnd = 204781, XrefRangeStart = 204767, XrefRangeEnd = 204781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(FrontFaceClosestHitCollector.NativeMethodInfoPtr_set_NumHits_Private_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769661, RefRangeEnd = 769662, XrefRangeStart = 769661, XrefRangeEnd = 769661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FrontFaceClosestHitCollector(
      NativeSlice<RigidBody> bodies,
      ref NativeList<RaycastHit> hits)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &bodies;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hits;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FrontFaceClosestHitCollector.NativeMethodInfoPtr__ctor_Public_Void_NativeSlice_1_RigidBody_byref_NativeList_1_RaycastHit_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 769662, XrefRangeEnd = 769666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool AddHit(RaycastHit hit)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &hit;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FrontFaceClosestHitCollector.NativeMethodInfoPtr_AddHit_Public_Virtual_Final_New_Boolean_RaycastHit_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 769677, RefRangeEnd = 769678, XrefRangeStart = 769666, XrefRangeEnd = 769677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsFrontFaceHit(RaycastHit hit)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &hit;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FrontFaceClosestHitCollector.NativeMethodInfoPtr_IsFrontFaceHit_Private_Boolean_RaycastHit_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static FrontFaceClosestHitCollector()
    {
      Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Physics", nameof (FrontFaceClosestHitCollector));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr);
      FrontFaceClosestHitCollector.NativeFieldInfoPtr__MaxFraction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr, "<MaxFraction>k__BackingField");
      FrontFaceClosestHitCollector.NativeFieldInfoPtr__NumHits_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr, "<NumHits>k__BackingField");
      FrontFaceClosestHitCollector.NativeFieldInfoPtr_Bodies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr, nameof (Bodies));
      FrontFaceClosestHitCollector.NativeFieldInfoPtr_Hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr, nameof (Hits));
      FrontFaceClosestHitCollector.NativeMethodInfoPtr_get_EarlyOutOnFirstHit_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr, 100668089);
      FrontFaceClosestHitCollector.NativeMethodInfoPtr_get_MaxFraction_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr, 100668090);
      FrontFaceClosestHitCollector.NativeMethodInfoPtr_set_MaxFraction_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr, 100668091);
      FrontFaceClosestHitCollector.NativeMethodInfoPtr_get_NumHits_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr, 100668092);
      FrontFaceClosestHitCollector.NativeMethodInfoPtr_set_NumHits_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr, 100668093);
      FrontFaceClosestHitCollector.NativeMethodInfoPtr__ctor_Public_Void_NativeSlice_1_RigidBody_byref_NativeList_1_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr, 100668094);
      FrontFaceClosestHitCollector.NativeMethodInfoPtr_AddHit_Public_Virtual_Final_New_Boolean_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr, 100668095);
      FrontFaceClosestHitCollector.NativeMethodInfoPtr_IsFrontFaceHit_Private_Boolean_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr, 100668096);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrontFaceClosestHitCollector>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

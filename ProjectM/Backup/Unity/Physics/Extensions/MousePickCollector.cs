// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Extensions.MousePickCollector
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace Unity.Physics.Extensions
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MousePickCollector
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreTriggers;
    private static readonly System.IntPtr NativeFieldInfoPtr_Bodies;
    private static readonly System.IntPtr NativeFieldInfoPtr_NumDynamicBodies;
    private static readonly System.IntPtr NativeFieldInfoPtr__MaxFraction_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__NumHits_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClosestHit;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_EarlyOutOnFirstHit_Public_Virtual_Final_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxFraction_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxFraction_Private_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_NumHits_Public_Virtual_Final_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_NumHits_Private_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Hit_Public_get_RaycastHit_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_NativeArray_1_RigidBody_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHit_Public_Virtual_Final_New_Boolean_RaycastHit_0;
    [FieldOffset(0)]
    public bool IgnoreTriggers;
    [FieldOffset(8)]
    public NativeArray<RigidBody> Bodies;
    [FieldOffset(24)]
    public int NumDynamicBodies;
    [FieldOffset(28)]
    public float _MaxFraction_k__BackingField;
    [FieldOffset(32)]
    public int _NumHits_k__BackingField;
    [FieldOffset(36)]
    public RaycastHit m_ClosestHit;

    public virtual unsafe bool EarlyOutOnFirstHit
    {
      [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MousePickCollector.NativeMethodInfoPtr_get_EarlyOutOnFirstHit_Public_Virtual_Final_New_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public virtual unsafe float MaxFraction
    {
      [CallerCount(36), CachedScanResults(RefRangeStart = 315333, RefRangeEnd = 315369, XrefRangeStart = 315333, XrefRangeEnd = 315369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MousePickCollector.NativeMethodInfoPtr_get_MaxFraction_Public_Virtual_Final_New_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 303604, RefRangeEnd = 303607, XrefRangeStart = 303604, XrefRangeEnd = 303607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MousePickCollector.NativeMethodInfoPtr_set_MaxFraction_Private_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe int NumHits
    {
      [CallerCount(36), CachedScanResults(RefRangeStart = 29682, RefRangeEnd = 29718, XrefRangeStart = 29682, XrefRangeEnd = 29718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MousePickCollector.NativeMethodInfoPtr_get_NumHits_Public_Virtual_Final_New_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MousePickCollector.NativeMethodInfoPtr_set_NumHits_Private_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe RaycastHit Hit
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MousePickCollector.NativeMethodInfoPtr_get_Hit_Public_get_RaycastHit_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(RaycastHit*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 926156, RefRangeEnd = 926157, XrefRangeStart = 926156, XrefRangeEnd = 926156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MousePickCollector(
      float maxFraction,
      NativeArray<RigidBody> rigidBodies,
      int numDynamicBodies)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &maxFraction;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rigidBodies;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &numDynamicBodies;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MousePickCollector.NativeMethodInfoPtr__ctor_Public_Void_Single_NativeArray_1_RigidBody_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926157, XrefRangeEnd = 926163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool AddHit(RaycastHit hit)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &hit;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MousePickCollector.NativeMethodInfoPtr_AddHit_Public_Virtual_Final_New_Boolean_RaycastHit_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MousePickCollector()
    {
      Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Extensions", nameof (MousePickCollector));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr);
      MousePickCollector.NativeFieldInfoPtr_IgnoreTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, nameof (IgnoreTriggers));
      MousePickCollector.NativeFieldInfoPtr_Bodies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, nameof (Bodies));
      MousePickCollector.NativeFieldInfoPtr_NumDynamicBodies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, nameof (NumDynamicBodies));
      MousePickCollector.NativeFieldInfoPtr__MaxFraction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, "<MaxFraction>k__BackingField");
      MousePickCollector.NativeFieldInfoPtr__NumHits_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, "<NumHits>k__BackingField");
      MousePickCollector.NativeFieldInfoPtr_m_ClosestHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, nameof (m_ClosestHit));
      MousePickCollector.NativeMethodInfoPtr_get_EarlyOutOnFirstHit_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, 100663985);
      MousePickCollector.NativeMethodInfoPtr_get_MaxFraction_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, 100663986);
      MousePickCollector.NativeMethodInfoPtr_set_MaxFraction_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, 100663987);
      MousePickCollector.NativeMethodInfoPtr_get_NumHits_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, 100663988);
      MousePickCollector.NativeMethodInfoPtr_set_NumHits_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, 100663989);
      MousePickCollector.NativeMethodInfoPtr_get_Hit_Public_get_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, 100663990);
      MousePickCollector.NativeMethodInfoPtr__ctor_Public_Void_Single_NativeArray_1_RigidBody_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, 100663991);
      MousePickCollector.NativeMethodInfoPtr_AddHit_Public_Virtual_Final_New_Boolean_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, 100663992);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MousePickCollector>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

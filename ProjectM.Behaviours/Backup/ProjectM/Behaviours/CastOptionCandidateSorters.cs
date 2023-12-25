// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.CastOptionCandidateSorters
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Behaviours
{
  public static class CastOptionCandidateSorters : Il2CppSystem.Object
  {
    static CastOptionCandidateSorters()
    {
      Il2CppClassPointerStore<CastOptionCandidateSorters>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (CastOptionCandidateSorters));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionCandidateSorters>.NativeClassPtr);
    }

    public CastOptionCandidateSorters(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Health_Absolute
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_HealthOf_Private_Static_Single_byref_ComponentDataFromEntity_1_Health_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Public_Void_byref_NativeList_1_CastOptionCandidate_ComponentDataFromEntity_1_Health_0;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1335745, RefRangeEnd = 1335747, XrefRangeStart = 1335739, XrefRangeEnd = 1335745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe float HealthOf(
        [In] ref ComponentDataFromEntity<Health> getHealth,
        Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref getHealth;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionCandidateSorters.Health_Absolute.NativeMethodInfoPtr_HealthOf_Private_Static_Single_byref_ComponentDataFromEntity_1_Health_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1335750, RefRangeEnd = 1335751, XrefRangeStart = 1335747, XrefRangeEnd = 1335750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Sort(
        ref NativeList<CastOptionCandidate> candidates,
        ComponentDataFromEntity<Health> getHealth)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref candidates;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getHealth;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastOptionCandidateSorters.Health_Absolute.NativeMethodInfoPtr_Sort_Public_Void_byref_NativeList_1_CastOptionCandidate_ComponentDataFromEntity_1_Health_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Health_Absolute()
      {
        Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Absolute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastOptionCandidateSorters>.NativeClassPtr, nameof (Health_Absolute));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Absolute>.NativeClassPtr);
        CastOptionCandidateSorters.Health_Absolute.NativeMethodInfoPtr_HealthOf_Private_Static_Single_byref_ComponentDataFromEntity_1_Health_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Absolute>.NativeClassPtr, 100664397);
        CastOptionCandidateSorters.Health_Absolute.NativeMethodInfoPtr_Sort_Public_Void_byref_NativeList_1_CastOptionCandidate_ComponentDataFromEntity_1_Health_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Absolute>.NativeClassPtr, 100664398);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Absolute>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct Sorter
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_GetHealth;
        private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CastOptionCandidate_CastOptionCandidate_0;
        [FieldOffset(0)]
        public ComponentDataFromEntity<Health> GetHealth;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335736, XrefRangeEnd = 1335739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe int Compare(CastOptionCandidate x, CastOptionCandidate y)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) &x;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionCandidateSorters.Health_Absolute.Sorter.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CastOptionCandidate_CastOptionCandidate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }

        static Sorter()
        {
          Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Absolute.Sorter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Absolute>.NativeClassPtr, nameof (Sorter));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Absolute.Sorter>.NativeClassPtr);
          CastOptionCandidateSorters.Health_Absolute.Sorter.NativeFieldInfoPtr_GetHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Absolute.Sorter>.NativeClassPtr, nameof (GetHealth));
          CastOptionCandidateSorters.Health_Absolute.Sorter.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CastOptionCandidate_CastOptionCandidate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Absolute.Sorter>.NativeClassPtr, 100664399);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Absolute.Sorter>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Health_Factor
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHealthFactor_Private_Static_Single_byref_ComponentDataFromEntity_1_Health_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Public_Void_byref_NativeList_1_CastOptionCandidate_ComponentDataFromEntity_1_Health_0;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1335758, RefRangeEnd = 1335760, XrefRangeStart = 1335754, XrefRangeEnd = 1335758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe float GetHealthFactor(
        [In] ref ComponentDataFromEntity<Health> getHealth,
        Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref getHealth;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionCandidateSorters.Health_Factor.NativeMethodInfoPtr_GetHealthFactor_Private_Static_Single_byref_ComponentDataFromEntity_1_Health_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1335763, RefRangeEnd = 1335764, XrefRangeStart = 1335760, XrefRangeEnd = 1335763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Sort(
        ref NativeList<CastOptionCandidate> candidates,
        ComponentDataFromEntity<Health> getHealth)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref candidates;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &getHealth;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastOptionCandidateSorters.Health_Factor.NativeMethodInfoPtr_Sort_Public_Void_byref_NativeList_1_CastOptionCandidate_ComponentDataFromEntity_1_Health_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Health_Factor()
      {
        Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Factor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastOptionCandidateSorters>.NativeClassPtr, nameof (Health_Factor));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Factor>.NativeClassPtr);
        CastOptionCandidateSorters.Health_Factor.NativeMethodInfoPtr_GetHealthFactor_Private_Static_Single_byref_ComponentDataFromEntity_1_Health_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Factor>.NativeClassPtr, 100664400);
        CastOptionCandidateSorters.Health_Factor.NativeMethodInfoPtr_Sort_Public_Void_byref_NativeList_1_CastOptionCandidate_ComponentDataFromEntity_1_Health_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Factor>.NativeClassPtr, 100664401);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Factor>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct Sorter
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_GetHealth;
        private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CastOptionCandidate_CastOptionCandidate_0;
        [FieldOffset(0)]
        public ComponentDataFromEntity<Health> GetHealth;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335751, XrefRangeEnd = 1335754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe int Compare(CastOptionCandidate x, CastOptionCandidate y)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) &x;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionCandidateSorters.Health_Factor.Sorter.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CastOptionCandidate_CastOptionCandidate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }

        static Sorter()
        {
          Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Factor.Sorter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Factor>.NativeClassPtr, nameof (Sorter));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Factor.Sorter>.NativeClassPtr);
          CastOptionCandidateSorters.Health_Factor.Sorter.NativeFieldInfoPtr_GetHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Factor.Sorter>.NativeClassPtr, nameof (GetHealth));
          CastOptionCandidateSorters.Health_Factor.Sorter.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CastOptionCandidate_CastOptionCandidate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Factor.Sorter>.NativeClassPtr, 100664402);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastOptionCandidateSorters.Health_Factor.Sorter>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Distance
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Public_Void_byref_NativeList_1_CastOptionCandidate_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1335768, RefRangeEnd = 1335769, XrefRangeStart = 1335765, XrefRangeEnd = 1335768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Sort(ref NativeList<CastOptionCandidate> candidates)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref candidates;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastOptionCandidateSorters.Distance.NativeMethodInfoPtr_Sort_Public_Void_byref_NativeList_1_CastOptionCandidate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static Distance()
      {
        Il2CppClassPointerStore<CastOptionCandidateSorters.Distance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastOptionCandidateSorters>.NativeClassPtr, nameof (Distance));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionCandidateSorters.Distance>.NativeClassPtr);
        CastOptionCandidateSorters.Distance.NativeMethodInfoPtr_Sort_Public_Void_byref_NativeList_1_CastOptionCandidate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionCandidateSorters.Distance>.NativeClassPtr, 100664403);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastOptionCandidateSorters.Distance>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct Sorter
      {
        private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CastOptionCandidate_CastOptionCandidate_0;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335764, XrefRangeEnd = 1335765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public virtual unsafe int Compare(CastOptionCandidate x, CastOptionCandidate y)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) &x;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionCandidateSorters.Distance.Sorter.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CastOptionCandidate_CastOptionCandidate_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(int*) IL2CPP.il2cpp_object_unbox(num);
        }

        static Sorter()
        {
          Il2CppClassPointerStore<CastOptionCandidateSorters.Distance.Sorter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastOptionCandidateSorters.Distance>.NativeClassPtr, nameof (Sorter));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionCandidateSorters.Distance.Sorter>.NativeClassPtr);
          CastOptionCandidateSorters.Distance.Sorter.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_CastOptionCandidate_CastOptionCandidate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionCandidateSorters.Distance.Sorter>.NativeClassPtr, 100664404);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastOptionCandidateSorters.Distance.Sorter>.NativeClassPtr, (System.IntPtr) ref this));
        }
      }
    }
  }
}

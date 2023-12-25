// Decompiled with JetBrains decompiler
// Type: ProjectM.HUD.ConditionalInfoAuthoring
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.HUD
{
  public class ConditionalInfoAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_PlayerMaxDistance;
    private static readonly IntPtr NativeFieldInfoPtr_InfoElements;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211823, XrefRangeEnd = 1211849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionalInfoAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConditionalInfoAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalInfoAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionalInfoAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConditionalInfoAuthoring()
    {
      Il2CppClassPointerStore<ConditionalInfoAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.HUD", nameof (ConditionalInfoAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalInfoAuthoring>.NativeClassPtr);
      ConditionalInfoAuthoring.NativeFieldInfoPtr_PlayerMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalInfoAuthoring>.NativeClassPtr, nameof (PlayerMaxDistance));
      ConditionalInfoAuthoring.NativeFieldInfoPtr_InfoElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionalInfoAuthoring>.NativeClassPtr, nameof (InfoElements));
      ConditionalInfoAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalInfoAuthoring>.NativeClassPtr, 100663800);
      ConditionalInfoAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalInfoAuthoring>.NativeClassPtr, 100663801);
    }

    public ConditionalInfoAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float PlayerMaxDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalInfoAuthoring.NativeFieldInfoPtr_PlayerMaxDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalInfoAuthoring.NativeFieldInfoPtr_PlayerMaxDistance)) = value;
      }
    }

    public unsafe ConditionalInfoAuthoring.ConditionalInfoElementArray InfoElements
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConditionalInfoAuthoring.NativeFieldInfoPtr_InfoElements));
        return pointer == IntPtr.Zero ? (ConditionalInfoAuthoring.ConditionalInfoElementArray) null : new ConditionalInfoAuthoring.ConditionalInfoElementArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConditionalInfoAuthoring.NativeFieldInfoPtr_InfoElements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class ConditionalInfoElementArray : ReorderableArray<ConditionalInfoElementAuthoring>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211820, XrefRangeEnd = 1211823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ConditionalInfoElementArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConditionalInfoAuthoring.ConditionalInfoElementArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ConditionalInfoAuthoring.ConditionalInfoElementArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ConditionalInfoElementArray()
      {
        Il2CppClassPointerStore<ConditionalInfoAuthoring.ConditionalInfoElementArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConditionalInfoAuthoring>.NativeClassPtr, nameof (ConditionalInfoElementArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionalInfoAuthoring.ConditionalInfoElementArray>.NativeClassPtr);
        ConditionalInfoAuthoring.ConditionalInfoElementArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionalInfoAuthoring.ConditionalInfoElementArray>.NativeClassPtr, 100663802);
      }

      public ConditionalInfoElementArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}

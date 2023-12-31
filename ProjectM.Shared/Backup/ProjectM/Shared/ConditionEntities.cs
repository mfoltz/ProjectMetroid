// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.ConditionEntities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ConditionEntities
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Self;
    private static readonly System.IntPtr NativeFieldInfoPtr_Owner;
    private static readonly System.IntPtr NativeFieldInfoPtr_Target;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Entity_ConditionTarget_0;
    [FieldOffset(0)]
    public readonly Entity Self;
    [FieldOffset(8)]
    public readonly Entity Owner;
    [FieldOffset(16)]
    public readonly Entity Target;

    [CallerCount(44)]
    [CachedScanResults(RefRangeStart = 800389, RefRangeEnd = 800433, XrefRangeStart = 800389, XrefRangeEnd = 800389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConditionEntities(Entity self, Entity owner, Entity target)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &self;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &owner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConditionEntities.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public unsafe Entity this[ConditionTarget target]
    {
      [CallerCount(83), CachedScanResults(RefRangeStart = 800433, RefRangeEnd = 800516, XrefRangeStart = 800433, XrefRangeEnd = 800433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &target;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConditionEntities.NativeMethodInfoPtr_get_Item_Public_get_Entity_ConditionTarget_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static ConditionEntities()
    {
      Il2CppClassPointerStore<ConditionEntities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (ConditionEntities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConditionEntities>.NativeClassPtr);
      ConditionEntities.NativeFieldInfoPtr_Self = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionEntities>.NativeClassPtr, nameof (Self));
      ConditionEntities.NativeFieldInfoPtr_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionEntities>.NativeClassPtr, nameof (Owner));
      ConditionEntities.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConditionEntities>.NativeClassPtr, nameof (Target));
      ConditionEntities.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionEntities>.NativeClassPtr, 100670604);
      ConditionEntities.NativeMethodInfoPtr_get_Item_Public_get_Entity_ConditionTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConditionEntities>.NativeClassPtr, 100670605);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConditionEntities>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}

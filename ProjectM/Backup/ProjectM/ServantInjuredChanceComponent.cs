// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantInjuredChanceComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class ServantInjuredChanceComponent : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Injured_Weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_Injured_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_Injured_Type;

    static ServantInjuredChanceComponent()
    {
      Il2CppClassPointerStore<ServantInjuredChanceComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ServantInjuredChanceComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantInjuredChanceComponent>.NativeClassPtr);
      ServantInjuredChanceComponent.NativeFieldInfoPtr_Injured_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInjuredChanceComponent>.NativeClassPtr, nameof (Injured_Weight));
      ServantInjuredChanceComponent.NativeFieldInfoPtr_Injured_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInjuredChanceComponent>.NativeClassPtr, nameof (Injured_Time));
      ServantInjuredChanceComponent.NativeFieldInfoPtr_Injured_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantInjuredChanceComponent>.NativeClassPtr, nameof (Injured_Type));
    }

    public ServantInjuredChanceComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ServantInjuredChanceComponent()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantInjuredChanceComponent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantInjuredChanceComponent>.NativeClassPtr, data));
    }

    public unsafe float Injured_Weight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInjuredChanceComponent.NativeFieldInfoPtr_Injured_Weight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInjuredChanceComponent.NativeFieldInfoPtr_Injured_Weight)) = value;
      }
    }

    public unsafe float Injured_Time
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInjuredChanceComponent.NativeFieldInfoPtr_Injured_Time));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInjuredChanceComponent.NativeFieldInfoPtr_Injured_Time)) = value;
      }
    }

    public unsafe MissionInjureDataAsset Injured_Type
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantInjuredChanceComponent.NativeFieldInfoPtr_Injured_Type));
        return pointer == System.IntPtr.Zero ? (MissionInjureDataAsset) null : new MissionInjureDataAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantInjuredChanceComponent.NativeFieldInfoPtr_Injured_Type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}

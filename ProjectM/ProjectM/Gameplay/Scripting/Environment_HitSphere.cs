// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Environment_HitSphere
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [Serializable]
  public class Environment_HitSphere : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Offset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117112, XrefRangeEnd = 1117113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Environment_HitSphere()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Environment_HitSphere>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Environment_HitSphere.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Environment_HitSphere()
    {
      Il2CppClassPointerStore<Environment_HitSphere>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Gameplay.Scripting", nameof (Environment_HitSphere));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Environment_HitSphere>.NativeClassPtr);
      Environment_HitSphere.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment_HitSphere>.NativeClassPtr, nameof (Offset));
      Environment_HitSphere.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Environment_HitSphere>.NativeClassPtr, nameof (Radius));
      Environment_HitSphere.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Environment_HitSphere>.NativeClassPtr, 100688553);
    }

    public Environment_HitSphere(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float3 Offset
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Environment_HitSphere.NativeFieldInfoPtr_Offset));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Environment_HitSphere.NativeFieldInfoPtr_Offset)) = value;
      }
    }

    public unsafe float Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Environment_HitSphere.NativeFieldInfoPtr_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Environment_HitSphere.NativeFieldInfoPtr_Radius)) = value;
      }
    }
  }
}

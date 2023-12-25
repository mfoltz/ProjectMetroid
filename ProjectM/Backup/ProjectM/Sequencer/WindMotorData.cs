// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.WindMotorData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WindMotorData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WindMotors;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entities;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Allocator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyFrom_Public_Void_WindMotorData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;
    [FieldOffset(0)]
    public NativeList<WindMotorOutput> WindMotors;
    [FieldOffset(16)]
    public NativeList<Entity> Entities;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1107219, RefRangeEnd = 1107221, XrefRangeStart = 1107213, XrefRangeEnd = 1107219, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WindMotorData(Allocator allocator)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &allocator;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindMotorData.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1107227, RefRangeEnd = 1107228, XrefRangeStart = 1107221, XrefRangeEnd = 1107227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindMotorData.NativeMethodInfoPtr_Clear_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1107246, RefRangeEnd = 1107247, XrefRangeStart = 1107228, XrefRangeEnd = 1107246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CopyFrom(WindMotorData other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindMotorData.NativeMethodInfoPtr_CopyFrom_Public_Void_WindMotorData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1107253, RefRangeEnd = 1107255, XrefRangeStart = 1107247, XrefRangeEnd = 1107253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WindMotorData.NativeMethodInfoPtr_Dispose_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WindMotorData()
    {
      Il2CppClassPointerStore<WindMotorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (WindMotorData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindMotorData>.NativeClassPtr);
      WindMotorData.NativeFieldInfoPtr_WindMotors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorData>.NativeClassPtr, nameof (WindMotors));
      WindMotorData.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindMotorData>.NativeClassPtr, nameof (Entities));
      WindMotorData.NativeMethodInfoPtr__ctor_Public_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorData>.NativeClassPtr, 100687713);
      WindMotorData.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorData>.NativeClassPtr, 100687714);
      WindMotorData.NativeMethodInfoPtr_CopyFrom_Public_Void_WindMotorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorData>.NativeClassPtr, 100687715);
      WindMotorData.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindMotorData>.NativeClassPtr, 100687716);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindMotorData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
